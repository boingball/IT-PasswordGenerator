//Copyright(c) 2024, Darren Banfi
//All rights reserved.
//
//This source code is licensed under the BSD-style license found in the
//LICENSE file in the root directory of this source tree. 
using MurrayGrant.ReadablePassphrase;
using PasswordGenerator;
using Devolutions.Zxcvbn;

namespace IT_PasswordGenerator
{
    public partial class PasswordMain : Form
    {
        //Setup the Password Vars out main loop
        //16Char Password
        Password pwd16 = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 16);
        //10Char Password
        Password pwd10 = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 10);
        //4Char Numbers
        Password pwd4 = new Password(includeLowercase: false, includeUppercase: false, includeNumeric: true, includeSpecial: false, passwordLength: 4);
        //4Char Special
        Password pwd4s = new Password(includeLowercase: false, includeUppercase: false, includeNumeric: false, includeSpecial: true, passwordLength: 4);


        public PasswordMain()
        {
            InitializeComponent();
        }

        private void genPassButton_Click(object sender, EventArgs e)
        {
            //Passprase Generation on Button Click
            var generator = MurrayGrant.ReadablePassphrase.Generator.Create();    // Create the generator.
            var combinations = generator.CalculateCombinations(PhraseStrength.Normal);
            var max = combinations.Shortest;
            var weightedAvg = combinations.Shortest;
            var phrase = generator.Generate(PhraseStrength.NormalSpeech);    // Generate a phrase.
            string[] splitPhrase = phrase.Split(new char[0]);
            //get rid of white spaces for phrase
            phrase = phrase.Replace(" ", "-");
            passwordDisplay.Text = phrase;
            //Check Password Stength - Evaluate how long the password would take to crack
            pass1Score.Text = CheckPasswordStrength(phrase);

            //Next Password Generated for all boxes
            var password16 = pwd16.Next();
            var password10 = pwd10.Next();
            var password4 = pwd4.Next();
            var password4s = pwd4s.Next();

            standardPass16Text.Text = password16;
            pass2Score.Text = CheckPasswordStrength(password16);
            standardPass10Text.Text = password10;
            pass3Score.Text = CheckPasswordStrength(password10);
            //MakeFirstChar Upper of Mixed Password
            string upperFirst = splitPhrase.First().Substring(0, 1).ToUpper() + splitPhrase.First().Substring(1).ToLower();
            mixedPassBox.Text = upperFirst;
            mixedPassBox.Text += password4.Substring(2);
            //MakeFirstChar of Lastpart Upper
            string upperSecond = splitPhrase.Last().Substring(0, 1).ToUpper() + splitPhrase.Last().Substring(1).ToLower();
            mixedPassBox.Text += upperSecond;
            mixedPassBox.Text += password4s.Substring(2);
            //Make sure we get to at least 13
            while (mixedPassBox.Text.Length < 13)
            {
                string xlpassword = mixedPassBox.Text + pwd4.Next();
                mixedPassBox.Text = xlpassword;

            }
            pass4Score.Text = CheckPasswordStrength(mixedPassBox.Text);
            //Make sure password is centuries on the hack scale if not keep generating characters
            while (pass4Score.Text != "centuries" && pass4Score.Text !="")
            {
                string xlpassword = mixedPassBox.Text + pwd4.Next();
                mixedPassBox.Text = xlpassword;
                pass4Score.Text = CheckPasswordStrength(mixedPassBox.Text);
            }
        }

        public static string CheckPasswordStrength(string password)
        {
            //Function to Check Password Stength using Zxcvbn
            ZxcvbnResult result = Zxcvbn.Evaluate(password);
            //string score = result.UnthrottledOnlineAttackCrackTime;
            string score = result.OfflineSlowHashManyCoresCrackTime;
            return score;
        }

        private void testPasswordBox_TextChanged(object sender, EventArgs e)
        {
            //Password stength user check
            if (testPasswordBox.Text != "")
            {
                pass5Score.Text = CheckPasswordStrength(testPasswordBox.Text);
                ZxcvbnResult result = Zxcvbn.Evaluate(testPasswordBox.Text);
                string feedback = result.Feedback.Warning;
                if (feedback != null)
                {
                    feedbackBox.Text = feedback;
                }
            }
            if (testPasswordBox.Text == "")
            {
                pass5Score.Text = "";
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            testPasswordBox.Text = "";
        }
    }
}
