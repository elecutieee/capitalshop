using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace quizgame
{
    public partial class Form1 : Form
    { //quizgame variables
        int correctanswer;
        int questionNumber;
        int score;
        int percentage;
        int totalQuestions;

        public Form1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestions = 10;

        }

        private void checkAnswerEvent(object sender, EventArgs e)
        {       

            var senderobject = (Button)sender;

            int buttonTag = Convert.ToInt32(senderobject.Tag);

            if (buttonTag == correctanswer)
            {
                score++;

            }
            if (questionNumber == totalQuestions)
            {
                //work out the percentage
                percentage = (int)Math.Round((double)(score * 100) / totalQuestions);

                MessageBox.Show(

                    "QUIZ ENDED" + Environment.NewLine +
                    "YOU HAVE ANSWERED  " + score + "questions correctly  " + Environment.NewLine +
                    "YOUR TOTAL PERCENTAGE IS " + percentage + "%" + Environment.NewLine +
                    "Click OK to play again"
                    );
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);






        }
        private void askQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1:
                    pictureBox1.Image = Properties.Resources._1;
                    lblquestion.Text = "Which of the following best signifies this image?";
                    button1.Text = "war at zweibrucken,german";
                    button2.Text = "people celebrating christmas";
                    button3.Text = "planting of tree of liberty";
                    button4.Text = "none of the above";

                    correctanswer = 3;

                    break;

                case 2:
                    pictureBox1.Image = Properties.Resources._2;
                    lblquestion.Text = "the painting 'the dream of worldwide democratic and social republics' was prepared by whom";
                    button1.Text = "Giuseppe Mazzini";
                    button2.Text = "Frederic Sorrieu";
                    button3.Text = "Henry Patulfo";
                    button4.Text = "Duke Metternich";

                    correctanswer = 2;

                    break;
                case 3:
                    pictureBox1.Image = Properties.Resources._3;
                    lblquestion.Text = "Which of the following aspect best signifies this image?";
                    button1.Text = "Round table conference at london";
                    button2.Text = "Consistuent assembly of india";
                    button3.Text = "the frankfurt parliament in the church of st.paul";
                    button4.Text = "the hall of mirrors of versailles";

                    correctanswer = 3;

                    break;
                case 4:
                    pictureBox1.Image = Properties.Resources._4;
                    lblquestion.Text = "what is shown in this picture as the basis of britain?";
                    button1.Text = "the sea routes which britain controlled";
                    button2.Text = "brittania sitting on the globe";
                    button3.Text = "its various colonies";
                    button4.Text = "its domination of the world";

                    correctanswer = 2;

                    break;
                case 5:
                    pictureBox1.Image = Properties.Resources._5;
                    lblquestion.Text = "Which of the following best describe his images by julius hubner?";
                    button1.Text = "defeat of otto von bismarck";
                    button2.Text = "the fallen germania";
                    button3.Text = "sleeping lady";
                    button4.Text = "none of the above";

                    correctanswer = 2;

                    break;
                case 6:
                    pictureBox1.Image = Properties.Resources._6;
                    lblquestion.Text = "Which of the following event was related to this image of 'gandhiji'";
                    button1.Text = "Non- cooperation movement";
                    button2.Text = "kheda satyagraha";
                    button3.Text = "dandi march";
                    button4.Text = "none of the above";

                    correctanswer = 3;

                    break;
                case 7:
                    pictureBox1.Image = Properties.Resources._7;
                    lblquestion.Text = "which following aspect best signifies this image of germania?";
                    button1.Text = "heroism and justice";
                    button2.Text = "folk and clutural tradition";
                    button3.Text = "austerity and asceticism";
                    button4.Text = "revenge and vengeance";

                    correctanswer = 1;
                    break;

                case 8:
                    pictureBox1.Image = Properties.Resources._8;
                    lblquestion.Text = "the event in the image is the explains the reason for the flee of louis philippine in 1948?";
                    button1.Text = "peasant uprising";
                    button2.Text = "revolution of liberals";
                    button3.Text = "outbreak of freanch revolution";
                    button4.Text = "war between france and prussia";

                    correctanswer = 1;

                    break;
                case 9:
                    pictureBox1.Image = Properties.Resources._9;
                    lblquestion.Text = "who is shown in this picture sitting on knees?";
                    button1.Text = "giuseppe mazzani";
                    button2.Text = "guiseppe garbaldi";
                    button3.Text = "victor emmanuel 2nd";
                    button4.Text = "cavour";

                    correctanswer = 2;

                    break;
                case 10:
                    pictureBox1.Image = Properties.Resources._10;
                    lblquestion.Text = "how is bharat mata portrayed in the above picture";
                    button1.Text = "ascetic";
                    button2.Text = "divine";
                    button3.Text = "spiritual";
                    button4.Text = "all of the above";

                    correctanswer = 4;

                    break;




            }

        }

        }
    }



