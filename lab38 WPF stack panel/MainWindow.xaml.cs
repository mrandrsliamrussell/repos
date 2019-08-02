using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace lab38_WPF_stack_panel
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<string> questions = new List<string>();
        public List<QuestionBank> QuestionsWithAnswers = new List<QuestionBank>();
        public Random rand = new Random();
        public int i, score;
        public MainWindow()
        {
            InitializeComponent();
            Initialise();
            Button01.Content = "New Question";
            Button02.Content = "This Button doesnt actually do anything";
            Button03.Content = "Submit Answer";
        }
       
        private void ShowPanel01(object sender, EventArgs e)
        {
            
            i = rand.Next(0, 3);
            QuestionLabel.Content = QuestionsWithAnswers[i].Question;
            AnswerInput.Text = "";
            
           
        }
        private void ShowPanel02(object sender, EventArgs e)
        {
            QuestionLabel.Content = "ok ok i lied";
        }
        private void ShowPanel03(object sender, EventArgs e)
        {
           if(QuestionsWithAnswers[i].Answer == AnswerInput.Text)
            {
                QuestionLabel.Content = "Correct well done";
                score += QuestionsWithAnswers[i].Points;
            }
            else
            {
                QuestionLabel.Content = "booo you suck";
            }
            ScoreLabel.Content = "score " + score;
        }
        public void Initialise()
        {
            

            questions.Add("what is the capital of italy");
            questions.Add("what is the airspeed velocity of an unlaiden swallow");
            questions.Add("what is the opposite do up");
            questions.Add("whats brown and sticky?");

            var qanda = new QuestionBank("What is the capital of Italy", "I", 69);
            var qanda2 = new QuestionBank("what is the airspeed velocity of an unlaiden swallow?", "what do you mean? english or african", 100);
            var qanda3 = new QuestionBank("what is the opposite of up?", "octopus", 8);
            var qanda4 = new QuestionBank("whats brown and sticky", "a stick", 1);
            QuestionsWithAnswers.Add(qanda);
            QuestionsWithAnswers.Add(qanda2);
            QuestionsWithAnswers.Add(qanda3);
            QuestionsWithAnswers.Add(qanda4);

        }

        public class QuestionBank
        {
            public string Question { get; set; }
            public string Answer { get; set; }

            public int Points { get; set; }

            public QuestionBank(string question, string answer, int points)
            {
                this.Question = question;
                this.Answer = answer;
                this.Points = points;

            }
        }
    }
}
