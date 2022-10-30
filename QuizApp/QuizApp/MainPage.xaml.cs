using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuizApp
{
    public partial class MainPage : ContentPage
    {
        int correctAnswerCount = 0;
        public MainPage()
        {
            InitializeComponent();
            imageFloss.Opacity = 0;

        }
        async void buttonStartQuiz_Clicked(object sender, EventArgs e)
        {
            RefreshAnswers();
            // QUESTION 1
            string q1Answer = await DisplayActionSheet("What breed is Flossy? ", "Cancel", null, "Arabian", "Quarter Horse", "Thoroughbred");
            if (q1Answer == "Thoroughbred")
            {
                labelQ1Answer.Text = "Correct, the answer was Thoroughbred";
                correctAnswerCount++;
            }
            else if (q1Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ1Answer.Text = "Incorrect, the answer was Thoroughbred";
            }

            // QUESTION 2
            string q2Answer = await DisplayActionSheet("What colour is Flossy? ", "Cancel", null, "Bay", "Chestnut", "Brown");
            if (q2Answer == "Bay")
            {
                labelQ2Answer.Text = "Correct, the answer was Bay";
                correctAnswerCount++;
            }
            else if (q2Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ2Answer.Text = "Incorrect, the answer was Bay";
            }

            // QUESTION 3
            string q3Answer = await DisplayActionSheet("What is Flossy's favourite treat? ", "Cancel", null, "Carrot", "Peppermint", "Liquorice");
            if (q3Answer == "Liquorice")
            {
                labelQ3Answer.Text = "Correct, the answer was Liquorice";
                correctAnswerCount++;
            }
            else if (q3Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ3Answer.Text = "Incorrect, the answer was Liquorice";
            }

            // QUESTION 4
            string q4Answer = await DisplayActionSheet("What is Flossy's paddock mate called? ", "Cancel", null, "Disco", "Florence", "Bailey");
            if (q4Answer == "Florence")
            {
                labelQ4Answer.Text = "Correct, the answer was Florence";
                correctAnswerCount++;
            }
            else if (q4Answer == null)
            {
                RefreshAnswers();
                return;
            }
            else
            {
                labelQ4Answer.Text = "Incorrect, the answer was Florence";
            }
            if (correctAnswerCount == 4)
            {
                imageFloss.Opacity = 100;
            }
        }

        void RefreshAnswers()
        {
            labelQ1Answer.Text = "";
            labelQ2Answer.Text = "";
            labelQ3Answer.Text = "";
            labelQ4Answer.Text = "";
            correctAnswerCount = 0;
            imageFloss.Opacity = 0;
        }


    }
}
