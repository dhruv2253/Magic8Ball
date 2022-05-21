using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magic8Ball
{
    public partial class Magic8Ball : Form
    {
        Random random = new Random();
        List<String> answers = new List<String>();
        public Magic8Ball()
        {
            InitializeComponent();
            //Positive outlook answers
            answers.Add("It is certain.");
            answers.Add("Without a doubt.");
            answers.Add("You may rely on it.");
            answers.Add("Most likely.");
            answers.Add("Yes.");
            
            //Unsure answers
            answers.Add("Reply hazy, try again.");
            answers.Add("Ask again later.");
            answers.Add("Better not tell you now.");
            answers.Add("Cannot predict now.");
            answers.Add("Concentrate and ask again.");
            //Negative answers
            answers.Add("Don’t count on it.");
            answers.Add("My reply is no.");
            answers.Add("My sources say no");
            answers.Add("Outlook not so good.");
            answers.Add("Very doubtful.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void questionBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int index = random.Next(answers.Count);
            answerLabel.Text = answers[index];
        }
    }
}
