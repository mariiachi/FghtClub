using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FightClub
{
    public partial class MainForm : Form
    {
        Fighter user;
        Fighter computer;

        public MainForm(string userName)
        {
            InitializeComponent();
            user = new Fighter(userName);
            computer = new Fighter("Тайлер Дёрден");

            userNameLabel.Text = user.Name;
            compNameLabel.Text = computer.Name;
            compNameLabel.Left = compHpProgress.Right - compNameLabel.Width;
            
          
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
            FightLog.Items.Add("Новичок обязан принять бой.");
            StartGame();           
            
            user.Block += UserBlock;
            user.Wound += UserWound;
            user.Death += UserDeath;

            computer.Block += ComputerBlock;
            computer.Wound += ComputerWound;
            computer.Death += ComputerDeath;
        }
        
        void StartGame()
        {
            FightLog.Items.Add("Защищайся.");
            user.Hp = 100;
            computer.Hp = 100;
            SetHpValues();
            AttackPanel.Visible = false;
            defendPanel.Visible = true;
        }

        void SetHpValues()
        {
            userHpProgress.Value = user.Hp;
            compHpProgress.Value = computer.Hp;
            userHpLabel.Text = user.Hp.ToString();
            compHpLabel.Text = computer.Hp.ToString();
            compHpLabel.Left = compHpProgress.Left - compHpLabel.Width - 5;
            userHpLabel.Left = userHpProgress.Right + 5;

        }

        void ComputerAttack()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 2);
            user.GetHit((BodyPart)i);
            
            if (user.Hp != 0 && computer.Hp != 0)
            {
                AttackPanel.Visible = true;
                defendPanel.Visible = false;
            }

            
        }

        void CompDefend()
        {
            Random rnd = new Random();
            int i = rnd.Next(0, 2);
            computer.SetBlock((BodyPart)i);
            
            if(user.Hp!=0&&computer.Hp!=0)
            {
                AttackPanel.Visible = false;
                defendPanel.Visible = true;
            }

            
        }

        private void headDefendButton_Click(object sender, EventArgs e)
        {
            user.SetBlock(BodyPart.Head);
            ComputerAttack();

        }


        private void BodyDefendButton_Click(object sender, EventArgs e)
        {
            user.SetBlock(BodyPart.Body);
            ComputerAttack();
            
        }

        private void LegsDefendButton_Click(object sender, EventArgs e)
        {
            user.SetBlock(BodyPart.Legs);
            ComputerAttack();
        }


        private void attackHeadButton_Click(object sender, EventArgs e)
        {
            computer.GetHit(BodyPart.Head);
            CompDefend();
           
        }

        private void attackBodybutton_Click(object sender, EventArgs e)
        {
            computer.GetHit(BodyPart.Body);
            CompDefend();
        }

        private void attackLegsbutton_Click(object sender, EventArgs e)
        {
            computer.GetHit(BodyPart.Legs);
            CompDefend();
        }


        private void UserBlock (object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            FightLog.Items.Add("Хороший блок! "+args.Name+"  HP: "+args.Hp+".");
            ScrollLog();

        }

        private void UserWound(object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            FightLog.Items.Add("Ауч! Это было больно. " + args.Name + "  HP: " + args.Hp + ".");
            ScrollLog();
        }

        private void UserDeath(object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            AttackPanel.Visible = false;
            defendPanel.Visible = false;
            FightLog.Items.Add("Кажется, ты умер. " + args.Name + "  HP: " + args.Hp + ".");
            FightLog.Items.Add("Мудрое решение с твоей стороны.");
            ScrollLog();

            DialogResult reloadOption = MessageBox.Show("Кажется, ты умер. Мудрое решение с твоей стороны.\n\nЗапустить новый бой?", "Oops!", MessageBoxButtons.YesNo);
            if (reloadOption == DialogResult.Yes)
            {
                FightLog.Items.Clear();
                StartGame();
            }
            else
            {
                this.Close();
            }
        }


        private void ComputerBlock(object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            FightLog.Items.Add("Я не хочу умереть без единого шрама. " + args.Name + "  HP: " + args.Hp + ".");
            ScrollLog();
        }

        private void ComputerWound(object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            FightLog.Items.Add("Неплохой удар. " + args.Name + "  HP: " + args.Hp + ".");
            ScrollLog();
        }

        private void ComputerDeath(object sender, FightCourseEventArgs args)
        {
            SetHpValues();
            AttackPanel.Visible = false;
            defendPanel.Visible = false;
            FightLog.Items.Add("В этот раз тебе повезло. " + args.Name + "  HP: " + args.Hp + ".");
            FightLog.Items.Add("Поздравляю с победой.");
            ScrollLog();
            
            DialogResult reloadOption = MessageBox.Show("В этот раз тебе повезло. Поздравляю с победой.\n\nЗапустить новый бой?","Congratulations!", MessageBoxButtons.YesNo);
            if(reloadOption==DialogResult.Yes)
            {
                FightLog.Items.Clear();
                StartGame();
            }
            else
            {
                this.Close();
            }
            
        }

        void ScrollLog()
        {
            FightLog.SelectedIndex = FightLog.Items.Count - 1;
            FightLog.SelectedIndex = -1;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добро пожаловать в Бойцовский клуб.\n\nПравила:\n- Игра строится на основе раундов.\n"+
"- В одном раунде один игрок атакует, другой защищается.\n- Атакующий игрок выбирет для удара часть "+
"тела оппонента(голова, корпус, ноги) с помощью соответствующих кнопок.\n- Защищающийся игрок выбирает часть тела для блока(голова, " +
"корпус, ноги) с помощью соответствующих кнопок.\n- Если защищенная и атакуемая части тела совпадут, очки жизни остануться прежними. Иначе отнимается 10 очков жизни.\n"+
"Победа игрока наступает, когда очки жизни его оппонента равны 0.\n- За ходом игры можно следить с помощью текстовых комментариев в нижней части экрана.\n"+
"- Очки жизни отображаются в верхней части экрана рядом с именами игроков.","Help",MessageBoxButtons.OK);
        }
    }
}
