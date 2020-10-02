using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace UserInterfaceV2
{
    public partial class Game : Form
    {
        /// <summary>
        /// To access the location, height and width of an enemy obstuction you can use 'Form1.container' to retrive a list of enemy obstuctions
        /// What still has to be done:
        /// - Connect the database
        ///     -pictures of enemy base buildings
        ///     -plane and jet information
        ///     -users in database
        /// - Generate report and link to database
        /// - Make database portable to the program
        /// - Fix Random Obstruction Generate Opverlap
        /// - Simulate Bombing and movement
        /// </summary>
        public Game()
        {
            InitializeComponent();
        }

        #region Global variables
        /// <summary>
        /// These are all the variables that are used in different methods throughout the form
        /// </summary>
        private bool collapsed;
        private bool collapsedTwo;
        public static Image pic;
        public static List<MapObj> container = new List<MapObj>();
        public static List<EnemyBaseObj> enemies = new List<EnemyBaseObj>();
        List<EnemyBaseObj> allEnemies = new List<EnemyBaseObj>();
        List<PlaneScouts> scoutPlanes = new List<PlaneScouts>();
        DataHandler dh = new DataHandler();
        bool[] targeted = new bool[6];
        Point locateE1 = new Point();
        Point locateE2 = new Point();
        Point locateE3 = new Point();
        Point locateE4 = new Point();
        Point locateE5 = new Point();
        Point locateE6 = new Point();
        public int obstructCounter;
        private System.Drawing.Point MouseDownLoaction;
        int maxLeft = 730;
        int minLeft = 150;
        int maxTop = 330;
        int top = 0;
        int left = 0;
        Thread t1 = null;
        int[] arrSelected = new int[5];
        bool isIdentical = false;
        PictureBox picboxE1 = null;
        PictureBox picboxE2 = null;
        PictureBox picboxE3 = null;
        PictureBox picboxE4 = null;
        PictureBox picboxE5 = null;
        PictureBox picboxE6 = null;
        int selectNumber = 0;

        public Map FormMap { get; set; }
        List<PictureBox> obstructList;

        #endregion

        #region Boundry Creation
        /// <summary>
        /// When the form loads it will point to a method that will create the boundry
        /// that method uses multicast delegates refers to methods that will use threading to actively look if objects are going outside the boarder
        /// if objects do move outside the thread will invoke a method to push the object back
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            pbAeroplane.Image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            allEnemies = dh.ObjReader();
            scoutPlanes = dh.PlaneScoutReader();
            btnA1.Text = scoutPlanes[0].Name;
            btnA2.Text = scoutPlanes[1].Name;
            btnA3.Text = scoutPlanes[2].Name;
            btnA1.Image = scoutPlanes[0].Picture;
            btnA2.Image = scoutPlanes[1].Picture;
            btnA3.Image = scoutPlanes[2].Picture;
            btnE1.Image = UserInterfaceV2.Resource1.E1;
            btnE2.Image = UserInterfaceV2.Resource1.E2;
            btnE3.Image = UserInterfaceV2.Resource1.E3;
            Boundry(); //reffering to method that create barrier for obstrcution objects
        }
        public void Boundry()
        {
            Checking a, b, c, d, e, f;
            a = new Checking(checkE1);
            b = new Checking(checkE2);
            c = new Checking(checkE3);
            d = new Checking(checkE4);
            e = new Checking(checkE5);
            f = new Checking(checkE6);
            t1 = new Thread(() =>
            {
                bool repeat = true;
                while (repeat)
                {
                    if (picboxE1 != null)
                    {
                        Invoke(a);
                    }
                    if (picboxE2 != null)
                    {
                        Invoke(b);
                    }
                    if (picboxE3 != null)
                    {
                        Invoke(c);
                    }
                    if (picboxE4 != null)
                    {
                        Invoke(d);
                    }
                    if (picboxE5 != null)
                    {
                        Invoke(e);
                    }
                    if (picboxE6 != null)
                    {
                        Invoke(f);
                    }
                }
            });
            t1.Start();
        }

        public delegate void Checking();

        public void checkE1()
        {
            if (picboxE1.Top <= 0)
            {
                picboxE1.Top = 0;
            }
            else if (picboxE1.Top >= maxTop)
            {
                picboxE1.Top = maxTop;
            }
            else if (picboxE1.Left < minLeft)
            {
                picboxE1.Left = minLeft;
            }
            else if (picboxE1.Left > maxLeft)
            {
                picboxE1.Left = maxLeft;
            }

            locateE1.X = picboxE1.Left;
            locateE1.Y = picboxE1.Top;
            foreach (var item in container)
            {
                if (item.Name == "E1")
                {
                    item.Coordinates = locateE1;
                }
            }
        }
        public void checkE2()
        {
            if (picboxE2.Top <= 0)
            {
                picboxE2.Top = 0;
            }
            else if (picboxE2.Top >= 330)
            {
                picboxE2.Top = 330;
            }
            else if (picboxE2.Left < minLeft)
            {
                picboxE2.Left = minLeft;
            }
            else if (picboxE2.Left > maxLeft)
            {
                picboxE2.Left = maxLeft;
            }
            locateE2.X = picboxE2.Left;
            locateE2.Y = picboxE2.Top;
            foreach (var item in container)
            {
                if (item.Name == "E2")
                {
                    item.Coordinates = locateE2;
                }
            }
        }
        public void checkE3()
        {
            if (picboxE3.Top <= 0)
            {
                picboxE3.Top = 0;
            }
            else if (picboxE3.Top >= 330)
            {
                picboxE3.Top = 330;
            }
            else if (picboxE3.Left < minLeft)
            {
                picboxE3.Left = minLeft;
            }
            else if (picboxE3.Left > maxLeft)
            {
                picboxE3.Left = maxLeft;
            }
            locateE3.X = picboxE3.Left;
            locateE3.Y = picboxE3.Top;
            foreach (var item in container)
            {
                if (item.Name == "E3")
                {
                    item.Coordinates = locateE3;
                }
            }
        }
        public void checkE4()
        {
            if (picboxE4.Top <= 0)
            {
                picboxE4.Top = 0;
            }
            else if (picboxE4.Top >= 330)
            {
                picboxE4.Top = 330;
            }
            else if (picboxE4.Left < minLeft)
            {
                picboxE4.Left = minLeft;
            }
            else if (picboxE4.Left > maxLeft)
            {
                picboxE4.Left = maxLeft;
            }
            locateE4.X = picboxE4.Left;
            locateE4.Y = picboxE4.Top;
            foreach (var item in container)
            {
                if (item.Name == "E4")
                {
                    item.Coordinates = locateE4;
                }
            }
        }
        public void checkE5()
        {
            if (picboxE5.Top <= 0)
            {
                picboxE5.Top = 0;
            }
            else if (picboxE5.Top >= 330)
            {
                picboxE5.Top = 330;
            }
            else if (picboxE5.Left < minLeft)
            {
                picboxE5.Left = minLeft;
            }
            else if (picboxE5.Left > maxLeft)
            {
                picboxE5.Left = maxLeft;
            }
            locateE5.X = picboxE5.Left;
            locateE5.Y = picboxE5.Top;
            foreach (var item in container)
            {
                if (item.Name == "E5")
                {
                    item.Coordinates = locateE5;
                }
            }
        }
        public void checkE6()
        {
            if (picboxE6.Top <= 0)
            {
                picboxE6.Top = 0;
            }
            else if (picboxE6.Top >= 330)
            {
                picboxE6.Top = 330;
            }
            else if (picboxE6.Left < minLeft)
            {
                picboxE6.Left = minLeft;
            }
            else if (picboxE6.Left > maxLeft)
            {
                picboxE6.Left = maxLeft;
            }
            locateE6.X = picboxE6.Left;
            locateE6.Y = picboxE6.Top;
            foreach (var item in container)
            {
                if (item.Name == "E6")
                {
                    item.Coordinates = locateE6;
                }
            }
        }
        #endregion

        #region Drop Down Selection Menu
        /// <summary>
        /// This is the code for the selection menu of aeroplanes and enemy obstructions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e) // this method is used for the drop down selection menu for aeroplane
        {
            if (collapsed)
            {
                pnlAeroplanes.Height += 10;
                if (pnlAeroplanes.Size == pnlAeroplanes.MaximumSize)
                {
                    timer1.Stop();
                    collapsed = false;
                }
            }
            else
            {
                pnlAeroplanes.Height -= 10;
                if (pnlAeroplanes.Size == pnlAeroplanes.MinimumSize)
                {
                    timer1.Stop();
                    collapsed = true;
                }
            }
        }

        private void btnAeroplane_Click(object sender, EventArgs e) // button that drops down aeroplane selection menu
        {
            timer1.Start();
            pnlAeroplanes.BringToFront();
        }

        private void timer2_Tick(object sender, EventArgs e) // this method is used for the drop down selection menu for Enemies
        {
            if (collapsedTwo)
            {
                pnlEnemies.Height += 10;
                if (pnlEnemies.Size == pnlEnemies.MaximumSize)
                {
                    timer2.Stop();
                    collapsedTwo = false;
                }
            }
            else
            {
                pnlEnemies.Height -= 10;
                if (pnlEnemies.Size == pnlEnemies.MinimumSize)
                {
                    timer2.Stop();
                    collapsedTwo = true;
                }
            }
        }

        private void btnEnemy_Click(object sender, EventArgs e) // button that drops down aeroplane selection menu
        {
            timer2.Start();
            pnlEnemies.BringToFront();
        }

        private void btnA1_Click(object sender, EventArgs e) // button that gives aeroplane image to aeroplane picture box
        {
            pic = UserInterfaceV2.Resource1.Plane1;
            pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = pic;
            

        }

        private void btnA2_Click(object sender, EventArgs e)// button that gives aeroplane image to aeroplane picture box
        {
            pic = UserInterfaceV2.Resource1.Plane2;
            pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = pic;
            
        }

        private void btnA3_Click(object sender, EventArgs e)// button that gives aeroplane image to aeroplane picture box
        {
            pic = UserInterfaceV2.Resource1.Plane3;
            pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = pic;
            
        }



        private void btnE1_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(1);

        }
        private void btnE2_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(2);
        }

        private void btnE3_Click(object sender, EventArgs e)//refers to a method that creates a enemy picture box with its appropriate fields
        {
            PbEnemyCreation(3);
        }
        #endregion

        #region Enemy Object Creation
        /// <summary>
        /// This creates the enemy objects using a random location (still fixing creation on top of one another)
        /// It gives the object an image*
        /// This Also subscribes the picture boxes to events that will allow it to move
        /// Then it creates the object onto the panel while also adding objects into a list
        /// *-suject to change
        /// </summary>
        /// <param name="imageID"></param>
        public void PbEnemyCreation(int imageID)
        {

            isIdentical = false;
            while (!isIdentical)
            {
                isIdentical = true;
                Random randomTop = new Random();
                top = randomTop.Next(0, maxTop);
                System.Threading.Thread.Sleep(30);
                Random randomLeft = new Random();
                left = randomLeft.Next(minLeft, maxLeft);
                foreach (MapObj item in container)
                {
                    if ((left <= item.Coordinates.X + 50 && left >= item.Coordinates.X && top <= item.Coordinates.Y + 50 && top >= item.Coordinates.Y)
                        || (left + 50 <= item.Coordinates.X + 50 && left + 50 >= item.Coordinates.X && top <= item.Coordinates.Y + 50 && top >= item.Coordinates.Y)
                        || (left <= item.Coordinates.X + 50 && left >= item.Coordinates.X && top + 50 <= item.Coordinates.Y + 50 && top + 50 >= item.Coordinates.Y)
                        || (left + 50 <= item.Coordinates.X + 50 && left + 50 >= item.Coordinates.X && top + 50 <= item.Coordinates.Y + 50 && top + 50 >= item.Coordinates.Y))
                    {
                        isIdentical = false;
                    }


                }
            }
            Image enemyImage = null;
            if (imageID == 1)
            {
                enemyImage = UserInterfaceV2.Resource1.E1;
            }
            else if (imageID == 2)
            {
                enemyImage = UserInterfaceV2.Resource1.E2;
            }
            else
            {
                enemyImage = UserInterfaceV2.Resource1.E3;
            }

            switch (selectNumber)
            {
                case 0:
                    {
                        picboxE1 = new PictureBox();
                        picboxE1.BringToFront();
                        this.panel1.Controls.Add(picboxE1);
                        picboxE1.Location = new System.Drawing.Point(left, top);
                        picboxE1.Name = "pbE1";
                        picboxE1.Size = new System.Drawing.Size(50, 50);
                        picboxE1.TabIndex = 0;
                        picboxE1.SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxE1.BackColor = Color.Transparent;
                        picboxE1.Image = enemyImage;
                        picboxE1.MouseDown += PbE_MouseDown;
                        picboxE1.MouseMove += PbE1_MouseMove;
                        selectNumber++;
                        container.Add(new MapObj("E1", locateE1, picboxE1.Width, picboxE1.Height, imageID.ToString(), enemyImage));
                    }
                    break;
                case 1:
                    {
                        picboxE2 = new PictureBox();
                        picboxE2.BringToFront();
                        this.panel1.Controls.Add(picboxE2);
                        picboxE2.Location = new System.Drawing.Point(left, top);
                        picboxE2.Name = "pbE2";
                        picboxE2.Size = new System.Drawing.Size(50, 50);
                        picboxE2.TabIndex = 0;
                        picboxE2.SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxE2.BackColor = Color.Transparent;
                        picboxE2.Image = enemyImage;
                        picboxE2.MouseDown += PbE_MouseDown;
                        picboxE2.MouseMove += PbE2_MouseMove;
                        selectNumber++;
                        container.Add(new MapObj("E2", locateE2, picboxE2.Width, picboxE2.Height, imageID.ToString(), enemyImage));
                    }
                    break;
                case 2:
                    {
                        picboxE3 = new PictureBox();
                        picboxE3.BringToFront();
                        this.panel1.Controls.Add(picboxE3);
                        picboxE3.Location = new System.Drawing.Point(left, top);
                        picboxE3.Name = "pbE3";
                        picboxE3.Size = new System.Drawing.Size(50, 50);
                        picboxE3.TabIndex = 0;
                        picboxE3.SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxE3.BackColor = Color.Transparent;
                        picboxE3.Image = enemyImage;
                        picboxE3.MouseDown += PbE_MouseDown;
                        picboxE3.MouseMove += PbE3_MouseMove;
                        selectNumber++;
                        container.Add(new MapObj("E3", locateE3, picboxE3.Width, picboxE3.Height, imageID.ToString(), enemyImage));
                    }
                    break;
                case 3:
                    {
                        picboxE4 = new PictureBox();
                        picboxE4.BringToFront();
                        this.panel1.Controls.Add(picboxE4);
                        picboxE4.Location = new System.Drawing.Point(left, top);
                        picboxE4.Name = "pbE4";
                        picboxE4.Size = new System.Drawing.Size(50, 50);
                        picboxE4.TabIndex = 0;
                        picboxE4.SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxE4.BackColor = Color.Transparent;
                        picboxE4.Image = enemyImage;
                        picboxE4.MouseDown += PbE_MouseDown;
                        picboxE4.MouseMove += PbE4_MouseMove;
                        selectNumber++;
                        container.Add(new MapObj("E4", locateE4, picboxE4.Width, picboxE4.Height, imageID.ToString(), enemyImage));

                    }
                    break;
                case 4:
                    {
                        picboxE5 = new PictureBox();
                        picboxE5.BringToFront();
                        this.panel1.Controls.Add(picboxE5);
                        picboxE5.Location = new System.Drawing.Point(left, top);
                        picboxE5.Name = "pbE5";
                        picboxE5.Size = new System.Drawing.Size(50, 50);
                        picboxE5.TabIndex = 0;
                        picboxE5.SizeMode = PictureBoxSizeMode.StretchImage;
                        picboxE5.BackColor = Color.Transparent;
                        picboxE5.Image = enemyImage;
                        picboxE5.MouseDown += PbE_MouseDown;
                        picboxE5.MouseMove += PbE5_MouseMove;
                        selectNumber++;
                        container.Add(new MapObj("E5", locateE5, picboxE5.Width, picboxE5.Height, imageID.ToString(), enemyImage));

                    }
                    break;

                default:
                    {
                        MessageBox.Show("Exceeded Item Limit", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    break;

            }
            obstructCounter++;

        }
        #endregion

        #region Object Movement
        /// <summary>
        /// This has methods for events that fire when the user clicks and holds on an enemy obstruction
        /// these methods have code to determine where the object moves
        /// it also checks whether the object that is being moved will not overlap ontop of another enemy obstruction
        /// At the end the code will set the location values accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PbE1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE1.Left >= minLeft && picboxE1.Top >= 0 && picboxE1.Left <= maxLeft && picboxE1.Top <= maxTop)
                {
                    picboxE1.Left = (int)(e.X + picboxE1.Left - MouseDownLoaction.X); ;
                    picboxE1.Top = (int)(e.Y + picboxE1.Top - MouseDownLoaction.Y); ;

                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E1")
                        {
                            if ((picboxE1.Left <= item.Coordinates.X + 50 && picboxE1.Left >= item.Coordinates.X + 5 && picboxE1.Top <= item.Coordinates.Y + 50 && picboxE1.Top >= item.Coordinates.Y) || (picboxE1.Left <= item.Coordinates.X + 50 && picboxE1.Left >= item.Coordinates.X + 5 && picboxE1.Top + 50 <= item.Coordinates.Y + 50 && picboxE1.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE1.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE1.Left + 50 >= item.Coordinates.X && picboxE1.Left + 5 <= item.Coordinates.X && picboxE1.Top <= item.Coordinates.Y + 50 && picboxE1.Top >= item.Coordinates.Y) || (picboxE1.Left + 50 >= item.Coordinates.X && picboxE1.Left + 5 <= item.Coordinates.X && picboxE1.Top + 50 <= item.Coordinates.Y + 50 && picboxE1.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE1.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE1.Top <= item.Coordinates.Y + 50 && picboxE1.Top >= item.Coordinates.Y + 5 && picboxE1.Left <= item.Coordinates.X + 50 && picboxE1.Left >= item.Coordinates.X) || (picboxE1.Top <= item.Coordinates.Y + 50 && picboxE1.Top >= item.Coordinates.Y + 5 && picboxE1.Left + 50 <= item.Coordinates.X + 50 && picboxE1.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE1.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE1.Top + 50 >= item.Coordinates.Y && picboxE1.Top + 5 <= item.Coordinates.Y && picboxE1.Left <= item.Coordinates.X + 50 && picboxE1.Left >= item.Coordinates.X) || (picboxE1.Top + 50 >= item.Coordinates.Y && picboxE1.Top + 5 <= item.Coordinates.Y && picboxE1.Left + 50 <= item.Coordinates.X + 50 && picboxE1.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE1.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    locateE1.X = picboxE1.Left;
                    locateE1.Y = picboxE1.Top;
                    foreach (var item in container)
                    {
                        if (item.Name == "E1")
                        {
                            item.Coordinates = locateE1;
                        }
                    }
                }
            }
        }
        private void PbE2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE2.Left >= minLeft && picboxE2.Top >= 0 && picboxE2.Left <= maxLeft && picboxE2.Top <= maxTop)
                {
                    picboxE2.Left = (int)(e.X + picboxE2.Left - MouseDownLoaction.X); ;
                    picboxE2.Top = (int)(e.Y + picboxE2.Top - MouseDownLoaction.Y); ;

                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E2")
                        {
                            if ((picboxE2.Left <= item.Coordinates.X + 50 && picboxE2.Left >= item.Coordinates.X + 5 && picboxE2.Top <= item.Coordinates.Y + 50 && picboxE2.Top >= item.Coordinates.Y) || (picboxE2.Left <= item.Coordinates.X + 50 && picboxE2.Left >= item.Coordinates.X + 5 && picboxE2.Top + 50 <= item.Coordinates.Y + 50 && picboxE2.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE2.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE2.Left + 50 >= item.Coordinates.X && picboxE2.Left + 5 <= item.Coordinates.X && picboxE2.Top <= item.Coordinates.Y + 50 && picboxE2.Top >= item.Coordinates.Y) || (picboxE2.Left + 50 >= item.Coordinates.X && picboxE2.Left + 5 <= item.Coordinates.X && picboxE2.Top + 50 <= item.Coordinates.Y + 50 && picboxE2.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE2.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE2.Top <= item.Coordinates.Y + 50 && picboxE2.Top >= item.Coordinates.Y + 5 && picboxE2.Left <= item.Coordinates.X + 50 && picboxE2.Left >= item.Coordinates.X) || (picboxE2.Top <= item.Coordinates.Y + 50 && picboxE2.Top >= item.Coordinates.Y + 5 && picboxE2.Left + 50 <= item.Coordinates.X + 50 && picboxE2.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE2.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE2.Top + 50 >= item.Coordinates.Y && picboxE2.Top + 5 <= item.Coordinates.Y && picboxE2.Left <= item.Coordinates.X + 50 && picboxE2.Left >= item.Coordinates.X) || (picboxE2.Top + 50 >= item.Coordinates.Y && picboxE2.Top + 5 <= item.Coordinates.Y && picboxE2.Left + 50 <= item.Coordinates.X + 50 && picboxE2.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE2.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    locateE2.X = picboxE2.Left;
                    locateE2.Y = picboxE2.Top;
                    foreach (var item in container)
                    {
                        if (item.Name == "E2")
                        {
                            item.Coordinates = locateE2;
                        }
                    }
                }
            }
        }
        private void PbE3_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE3.Left >= minLeft && picboxE3.Top >= 0 && picboxE3.Left <= maxLeft && picboxE3.Top <= maxTop)
                {
                    picboxE3.Left = (int)(e.X + picboxE3.Left - MouseDownLoaction.X); ;
                    picboxE3.Top = (int)(e.Y + picboxE3.Top - MouseDownLoaction.Y); ;

                    locateE3.X = picboxE3.Left;
                    locateE3.Y = picboxE3.Top;
                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E3")
                        {
                            if ((picboxE3.Left <= item.Coordinates.X + 50 && picboxE3.Left >= item.Coordinates.X + 5 && picboxE3.Top <= item.Coordinates.Y + 50 && picboxE3.Top >= item.Coordinates.Y) || (picboxE3.Left <= item.Coordinates.X + 50 && picboxE3.Left >= item.Coordinates.X + 5 && picboxE3.Top + 50 <= item.Coordinates.Y + 50 && picboxE3.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE3.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE3.Left + 50 >= item.Coordinates.X && picboxE3.Left + 5 <= item.Coordinates.X && picboxE3.Top <= item.Coordinates.Y + 50 && picboxE3.Top >= item.Coordinates.Y) || (picboxE3.Left + 50 >= item.Coordinates.X && picboxE3.Left + 5 <= item.Coordinates.X && picboxE3.Top + 50 <= item.Coordinates.Y + 50 && picboxE3.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE3.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE3.Top <= item.Coordinates.Y + 50 && picboxE3.Top >= item.Coordinates.Y + 5 && picboxE3.Left <= item.Coordinates.X + 50 && picboxE3.Left >= item.Coordinates.X) || (picboxE3.Top <= item.Coordinates.Y + 50 && picboxE3.Top >= item.Coordinates.Y + 5 && picboxE3.Left + 50 <= item.Coordinates.X + 50 && picboxE3.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE3.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE3.Top + 50 >= item.Coordinates.Y && picboxE3.Top + 5 <= item.Coordinates.Y && picboxE3.Left <= item.Coordinates.X + 50 && picboxE3.Left >= item.Coordinates.X) || (picboxE3.Top + 50 >= item.Coordinates.Y && picboxE3.Top + 5 <= item.Coordinates.Y && picboxE3.Left + 50 <= item.Coordinates.X + 50 && picboxE3.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE3.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E3")
                        {
                            item.Coordinates = locateE3;
                        }
                    }
                }
            }
        }
        private void PbE4_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE4.Left >= minLeft && picboxE4.Top >= 0 && picboxE4.Left <= maxLeft && picboxE4.Top <= maxTop)
                {
                    picboxE4.Left = (int)(e.X + picboxE4.Left - MouseDownLoaction.X); ;
                    picboxE4.Top = (int)(e.Y + picboxE4.Top - MouseDownLoaction.Y); ;

                    locateE4.X = picboxE4.Left;
                    locateE4.Y = picboxE4.Top;
                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E4")
                        {
                            if ((picboxE4.Left <= item.Coordinates.X + 50 && picboxE4.Left >= item.Coordinates.X + 5 && picboxE4.Top <= item.Coordinates.Y + 50 && picboxE4.Top >= item.Coordinates.Y) || (picboxE4.Left <= item.Coordinates.X + 50 && picboxE4.Left >= item.Coordinates.X + 5 && picboxE4.Top + 50 <= item.Coordinates.Y + 50 && picboxE4.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE4.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE4.Left + 50 >= item.Coordinates.X && picboxE4.Left + 5 <= item.Coordinates.X && picboxE4.Top <= item.Coordinates.Y + 50 && picboxE4.Top >= item.Coordinates.Y) || (picboxE4.Left + 50 >= item.Coordinates.X && picboxE4.Left + 5 <= item.Coordinates.X && picboxE4.Top + 50 <= item.Coordinates.Y + 50 && picboxE4.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE4.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE4.Top <= item.Coordinates.Y + 50 && picboxE4.Top >= item.Coordinates.Y + 5 && picboxE4.Left <= item.Coordinates.X + 50 && picboxE4.Left >= item.Coordinates.X) || (picboxE4.Top <= item.Coordinates.Y + 50 && picboxE4.Top >= item.Coordinates.Y + 5 && picboxE4.Left + 50 <= item.Coordinates.X + 50 && picboxE4.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE4.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE4.Top + 50 >= item.Coordinates.Y && picboxE4.Top + 5 <= item.Coordinates.Y && picboxE4.Left <= item.Coordinates.X + 50 && picboxE4.Left >= item.Coordinates.X) || (picboxE4.Top + 50 >= item.Coordinates.Y && picboxE4.Top + 5 <= item.Coordinates.Y && picboxE4.Left + 50 <= item.Coordinates.X + 50 && picboxE4.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE4.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E4")
                        {
                            item.Coordinates = locateE4;
                        }
                    }
                }
            }
        }
        private void PbE5_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE5.Left >= minLeft && picboxE5.Top >= 0 && picboxE5.Left <= maxLeft && picboxE5.Top <= maxTop)
                {
                    picboxE5.Left = (int)(e.X + picboxE5.Left - MouseDownLoaction.X); ;
                    picboxE5.Top = (int)(e.Y + picboxE5.Top - MouseDownLoaction.Y); ;

                    locateE5.X = picboxE5.Left;
                    locateE5.Y = picboxE5.Top;
                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E5")
                        {
                            if ((picboxE5.Left <= item.Coordinates.X + 50 && picboxE5.Left >= item.Coordinates.X + 5 && picboxE5.Top <= item.Coordinates.Y + 50 && picboxE5.Top >= item.Coordinates.Y) || (picboxE5.Left <= item.Coordinates.X + 50 && picboxE5.Left >= item.Coordinates.X + 5 && picboxE5.Top + 50 <= item.Coordinates.Y + 50 && picboxE5.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE5.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE5.Left + 50 >= item.Coordinates.X && picboxE5.Left + 5 <= item.Coordinates.X && picboxE5.Top <= item.Coordinates.Y + 50 && picboxE5.Top >= item.Coordinates.Y) || (picboxE5.Left + 50 >= item.Coordinates.X && picboxE5.Left + 5 <= item.Coordinates.X && picboxE5.Top + 50 <= item.Coordinates.Y + 50 && picboxE5.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE5.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE5.Top <= item.Coordinates.Y + 50 && picboxE5.Top >= item.Coordinates.Y + 5 && picboxE5.Left <= item.Coordinates.X + 50 && picboxE5.Left >= item.Coordinates.X) || (picboxE5.Top <= item.Coordinates.Y + 50 && picboxE5.Top >= item.Coordinates.Y + 5 && picboxE5.Left + 50 <= item.Coordinates.X + 50 && picboxE5.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE5.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE5.Top + 50 >= item.Coordinates.Y && picboxE5.Top + 5 <= item.Coordinates.Y && picboxE5.Left <= item.Coordinates.X + 50 && picboxE5.Left >= item.Coordinates.X) || (picboxE5.Top + 50 >= item.Coordinates.Y && picboxE5.Top + 5 <= item.Coordinates.Y && picboxE5.Left + 50 <= item.Coordinates.X + 50 && picboxE5.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE5.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E5")
                        {
                            item.Coordinates = locateE5;
                        }
                    }
                }
            }
        }
        private void PbE6_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (picboxE6.Left >= minLeft && picboxE6.Top >= 0 && picboxE6.Left <= maxLeft && picboxE6.Top <= maxTop)
                {
                    picboxE6.Left = (int)(e.X + picboxE6.Left - MouseDownLoaction.X); ;
                    picboxE6.Top = (int)(e.Y + picboxE6.Top - MouseDownLoaction.Y); ;

                    locateE6.X = picboxE6.Left;
                    locateE6.Y = picboxE6.Top;
                    foreach (MapObj item in container)
                    {
                        if (item.Name != "E6")
                        {
                            if ((picboxE6.Left <= item.Coordinates.X + 50 && picboxE6.Left >= item.Coordinates.X + 5 && picboxE6.Top <= item.Coordinates.Y + 50 && picboxE6.Top >= item.Coordinates.Y) || (picboxE6.Left <= item.Coordinates.X + 50 && picboxE6.Left >= item.Coordinates.X + 5 && picboxE6.Top + 50 <= item.Coordinates.Y + 50 && picboxE6.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE6.Left = (int)(item.Coordinates.X + 52);
                            }
                            if ((picboxE6.Left + 50 >= item.Coordinates.X && picboxE6.Left + 5 <= item.Coordinates.X && picboxE6.Top <= item.Coordinates.Y + 50 && picboxE6.Top >= item.Coordinates.Y) || (picboxE6.Left + 50 >= item.Coordinates.X && picboxE6.Left + 5 <= item.Coordinates.X && picboxE6.Top + 50 <= item.Coordinates.Y + 50 && picboxE6.Top + 50 >= item.Coordinates.Y))
                            {
                                picboxE1.Left = (int)(item.Coordinates.X - 52);
                            }
                            if ((picboxE6.Top <= item.Coordinates.Y + 50 && picboxE6.Top >= item.Coordinates.Y + 5 && picboxE6.Left <= item.Coordinates.X + 50 && picboxE6.Left >= item.Coordinates.X) || (picboxE6.Top <= item.Coordinates.Y + 50 && picboxE6.Top >= item.Coordinates.Y + 5 && picboxE6.Left + 50 <= item.Coordinates.X + 50 && picboxE6.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE6.Top = (int)(item.Coordinates.Y + 52);
                            }
                            if ((picboxE6.Top + 50 >= item.Coordinates.Y && picboxE6.Top + 5 <= item.Coordinates.Y && picboxE6.Left <= item.Coordinates.X + 50 && picboxE6.Left >= item.Coordinates.X) || (picboxE6.Top + 50 >= item.Coordinates.Y && picboxE6.Top + 5 <= item.Coordinates.Y && picboxE6.Left + 50 <= item.Coordinates.X + 50 && picboxE6.Left + 50 >= item.Coordinates.X))
                            {
                                picboxE6.Top = (int)(item.Coordinates.Y - 52);
                            }
                        }
                    }
                    foreach (var item in container)
                    {
                        if (item.Name == "E6")
                        {
                            item.Coordinates = locateE6;
                        }
                    }
                }
            }
        }

        private void PbE_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                MouseDownLoaction = e.Location;
            }
        }
        #endregion

        #region Other Buttons
        /// <summary>
        /// There are three other buttons with minimal code here
        /// The undo button will remove the most recently added enemy obstruction from the map and list
        /// Start simulation button shows the simulation form as well as randomly generating what is inside the enemy base and storing it in a list from a list populated by the database 
        /// The exit button to the program, opens up a dialog result box to get the input from the user on whether or not the want to exit the program.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUndo_Click(object sender, EventArgs e)
        {

            switch (selectNumber)
            {
                case 1:
                    {
                        this.panel1.Controls.Remove(picboxE1);
                        selectNumber--;
                        container.RemoveAt(0);
                    }
                    break;
                case 2:
                    {
                        this.panel1.Controls.Remove(picboxE2);
                        selectNumber--;
                        container.RemoveAt(1);
                    }
                    break;
                case 3:
                    {
                        this.panel1.Controls.Remove(picboxE3);
                        selectNumber--;
                        container.RemoveAt(2);
                    }
                    break;
                case 4:
                    {
                        this.panel1.Controls.Remove(picboxE4);
                        selectNumber--;
                        container.RemoveAt(3);
                    }
                    break;
                case 5:
                    {
                        this.panel1.Controls.Remove(picboxE5);
                        selectNumber--;
                        container.RemoveAt(4);
                    }
                    break;
                case 6:
                    {
                        this.panel1.Controls.Remove(picboxE6);
                        selectNumber--;
                        container.RemoveAt(5);
                    }
                    break;
                default:
                    {
                        MessageBox.Show("No More Items Left To Undo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;

            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 6; i++)
            {
                targeted[i] = false;
            }
            pb1.InitialImage = null;
            pb1.Visible = false;
            pb2.InitialImage = null;
            pb2.Visible = false;
            pb3.InitialImage = null;
            pb3.Visible = false;
            pb4.InitialImage = null;
            pb4.Visible = false;
            pb5.InitialImage = null;
            pb5.Visible = false;
            pb6.InitialImage = null;
            pb6.Visible = false;
            pnlAeroplanes.Size = pnlAeroplanes.MinimumSize;
            pnlEnemies.Size = pnlEnemies.MinimumSize;
            EnemyBaseObj temp = new EnemyBaseObj();
            enemies.Clear();
            Random randomObject = new Random();
            for (int i = 0; i < 6; i++)
            {

                int enemyID = randomObject.Next(1, 9);
                foreach (EnemyBaseObj item in allEnemies)
                {
                    if (item.ID == enemyID)
                    {
                        temp = item;
                        enemies.Add(temp);
                    }
                }
            }
            AstarSearchNewMap();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                DataHandler handler = new DataHandler();
                List<Player> players = new List<Player>();
                players.Add(new Player(Login.startTime.ToString(), Login.userName, DateTime.Now.ToString()));
                handler.PlayerWrite(players);
                t1.Abort();
                Environment.Exit(0);
            }
            else { e.Cancel = true; }
        }

        #endregion

        #region Route calculation and movement
        /// <summary>
        /// The Map of nodes in the  map class will be used to show the graphic to display the route
        /// The Map is also generated using the A* algorithim
        /// The plane movement , printing of reports and bombing the base is all initiated  here
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 


        //this is used to draw the line, to show the path that the plane takes
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            if (FormMap == null)
                return;
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            var sideX = e.ClipRectangle.Width;
            var sideY = e.ClipRectangle.Height;

            var pen = new Pen(Brushes.DarkOliveGreen, 2);
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node1 = FormMap.ShortestPath[i];
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node1.Point.X * sideX;
                var y1 = node1.Point.Y * sideY;
                var x2 = node2.Point.X * sideX;
                var y2 = node2.Point.Y * sideY;
                g.DrawLine(pen, (float)x1, (float)y1, (float)x2, (float)y2);
            }
        }

        

        private void AstarSearchNewMap()
        {
            obstructList = new List<PictureBox>();
            if (picboxE1 != null)
            {
                obstructList.Add(picboxE1);
            }
            if (picboxE2 != null)
            {
                obstructList.Add(picboxE2);
            }
            if (picboxE3 != null)
            {
                obstructList.Add(picboxE3);
            }
            if (picboxE4 != null)
            {
                obstructList.Add(picboxE4);
            }
            if (picboxE5 != null)
            {
                obstructList.Add(picboxE5);
            }
            if (picboxE6 != null)
            {
                obstructList.Add(picboxE6);
            }

            FormMap = Map.Generate(obstructList, pbAeroplane, pb4);
            var search = new SearchEngine(FormMap);
            search.Updated += Search_Updated;
            var sw = Stopwatch.StartNew();
            FormMap.ShortestPath = search.GetShortestPathAstart();
            sw.Stop();


            MoveScout();
            ReturnScout();
            PopulateBase();
            LoadBomber(search);
            PrintReport(search);
            panel1.Invalidate();
            Update();
            Thread.Sleep(2000);

            MoveBomber();
            ReturnBomber();
            FinalReport(search);
            Update();
        }
        #endregion

        #region Simulation
        /// <summary>
        /// this methods are what is used to run the simulation
        /// It is made up of :reports, switching the planes, flying the routes, loading the planes and bombing the base
        /// The enemy base is also generated a
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PrintReport(SearchEngine search)
        {
            richTextBox1.Text = $"Path length: {search.ShortestRouteLength.ToString("0.00")} km\r\n" +
                $"Enemy Base Contains:\r\n" +
                $"\t- {enemies[0].Name}\r\n" +
                $"\t- {enemies[1].Name}\r\n" +
                $"\t- {enemies[2].Name}\r\n" +
                $"\t- {enemies[3].Name}\r\n" +
                $"\t- {enemies[4].Name}\r\n" +
                $"\t- {enemies[5].Name}\r\n" +
                $"Highest Priority Target: {higestPriority.Name}\r\n" +
                $"Recommended Plane: {newBomber.Name}\r\n" +
                $"Required Fuel: {(search.ShortestRouteLength * 50 * 2).ToString("0.00")} galons\r\n";
        }

        private void Search_Updated(object sender, EventArgs e)
        {
            panel1.Invalidate();
            Application.DoEvents();
            Thread.Sleep(300);
        }

        private void MoveScout()
        {
            pbAeroplane.BringToFront();
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node2.Point.X * 890 - 7;
                var y1 = node2.Point.Y * 388 - 7;
                pbAeroplane.Location = new System.Drawing.Point((int)x1, (int)y1);
                Thread.Sleep(50);
                Update();
            }
            pb1.Visible = true;
            pb2.Visible = true;
            pb3.Visible = true;
            pb4.Visible = true;
            pb5.Visible = true;
            pb6.Visible = true;
        }

        private void ReturnScout()
        {
            FormMap.ShortestPath.Reverse();
            var img = pbAeroplane.Image;
            img.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbAeroplane.Image = img;
            pbAeroplane.BringToFront();
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node2.Point.X * 890 - 7;
                var y1 = node2.Point.Y * 388 - 7;
                pbAeroplane.Location = new System.Drawing.Point((int)x1, (int)y1);
                Thread.Sleep(50);
                Update();
            }
        }
        EnemyBaseObj higestPriority = null;

        private void PopulateBase()
        {
            int pictureBoxCount = 0;
            int highNum = 0;
            int highVal = 0;
            for (pictureBoxCount = 1; pictureBoxCount < 7; pictureBoxCount++)
            {
                int index = pictureBoxCount - 1;
                if (pictureBoxCount == 1)
                {
                    pb1.BackgroundImage = enemies[0].Pictures;
                    enemies[0].Location = pictureBoxCount;
                    if (enemies[0].Points >= 10)
                    {
                        enemies[0].Targeted = true;
                        targeted[0] = true;
                    }
                    if (enemies[0].Points >= highVal)
                    {
                        highNum = 0;
                        highVal = enemies[0].Points;
                    }
                }
                if (pictureBoxCount == 2)
                {
                    pb2.BackgroundImage = enemies[1].Pictures;
                    enemies[1].Location = pictureBoxCount;
                    if (enemies[1].Points >= 10)
                    {
                        enemies[1].Targeted = true;
                        targeted[1] = true;
                    }
                    if (enemies[1].Points >= highVal)
                    {
                        highNum = 1;
                        highVal = enemies[1].Points;
                    }
                }
                if (pictureBoxCount == 3)
                {
                    pb3.BackgroundImage = enemies[2].Pictures;
                    enemies[2].Location = pictureBoxCount;
                    if (enemies[2].Points >= 10)
                    {
                        enemies[2].Targeted = true;
                        targeted[2] = true;
                    }
                    if (enemies[2].Points >= highVal)
                    {
                        highNum = 2;
                        highVal = enemies[2].Points;
                    }
                }
                if (pictureBoxCount == 4)
                {
                    pb4.BackgroundImage = enemies[3].Pictures;
                    enemies[3].Location = pictureBoxCount;
                    if (enemies[3].Points >= 10)
                    {
                        enemies[3].Targeted = true;
                        targeted[3] = true;
                    }
                    if (enemies[3].Points >= highVal)
                    {
                        highNum = 3;
                        highVal = enemies[3].Points;
                    }
                }
                if (pictureBoxCount == 5)
                {
                    pb5.BackgroundImage = enemies[4].Pictures;
                    enemies[4].Location = pictureBoxCount;
                    if (enemies[4].Points >= 10)
                    {
                        enemies[4].Targeted = true;
                        targeted[4] = true;
                    }
                    if (enemies[4].Points >= highVal)
                    {
                        highNum = 4;
                        highVal = enemies[4].Points;
                    }
                }
                if (pictureBoxCount == 6)
                {
                    pb6.BackgroundImage = enemies[5].Pictures;
                    enemies[5].Location = pictureBoxCount;
                    if (enemies[5].Points >= 10)
                    {
                        enemies[5].Targeted = true;
                        targeted[5] = true;
                    }
                    if (enemies[5].Points >= highVal)
                    {
                        highNum = 5;
                        highVal = enemies[5].Points;
                    }
                }
            }
            higestPriority = enemies[highNum];

        }

        BomberPlane newBomber = null;

        private void LoadBomber(SearchEngine search)
        {
            int ammo = 0;
            foreach (var item in enemies)
            {
                if (item.Targeted)
                {
                    ammo++;
                }
            }
            if (ammo == 0)
            {
                ammo = 1;
            }
            newBomber = dh.BomberReader(ammo);
            progressBar1.Maximum = (int)newBomber.MaxFuel;
            if (search.ShortestRouteLength * 50 * 2 >= 100 && ammo == 1)
            {
                newBomber = dh.BomberReader(3);
                progressBar1.Maximum = 150;
            }
            if (search.ShortestRouteLength * 50 * 2 >= 150 && ammo <= 3)
            {
                newBomber = dh.BomberReader(6);
                progressBar1.Maximum = 200;
            }
            newBomber.Bombs = ammo;
            newBomber.Fuel = search.ShortestRouteLength * 50 * 2;
            var img = newBomber.Picture;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = img;
        }

        double startingFuel = 0;

        int targetCount = 0;
        private void MoveBomber()
        {

            startingFuel = newBomber.Fuel;
            progressBar1.Value = (int)startingFuel;
            var pic = pbAeroplane.Image;
            pbAeroplane.Image = pic;
            FormMap.ShortestPath.Reverse();
            pbAeroplane.BringToFront();
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node2.Point.X * 890 - 7;
                var y1 = node2.Point.Y * 388 - 7;
                pbAeroplane.Location = new System.Drawing.Point((int)x1, (int)y1);
                newBomber.Fuel = newBomber.Fuel - (startingFuel / (FormMap.ShortestPath.Count * 2));
                progressBar1.Value = (int)newBomber.Fuel;
                Thread.Sleep(50);
                Update();
            }

            bombTime = DateTime.Now;

            targetCount = 0;
            for (int i = 0; i < 6; i++)
            {
                if (targeted[i])
                {
                    if (i==0)
                    {
                        pb1.Visible = false;
                    }
                    if (i == 1)
                    {
                        pb2.Visible = false;
                    }
                    if (i == 2)
                    {
                        pb3.Visible = false;
                    }
                    if (i == 3)
                    {
                        pb4.Visible = false;
                    }
                    if (i == 4)
                    {
                        pb5.Visible = false;
                    }
                    if (i == 5)
                    {
                        pb6.Visible = false;
                    }
                }
            }
            if (targetCount == 0)
            {
                targetCount++;
                if (higestPriority.Location == 1)
                {
                    pb1.Visible = false;
                }
                if (higestPriority.Location == 2)
                {
                    pb2.Visible = false;
                }
                if (higestPriority.Location == 3)
                {
                    pb3.Visible = false;
                }
                if (higestPriority.Location == 4)
                {
                    pb4.Visible = false;
                }
                if (higestPriority.Location == 5)
                {
                    pb5.Visible = false;
                }
                if (higestPriority.Location == 6)
                {
                    pb6.Visible = false;
                }
            }
        }
        private void ReturnBomber()
        {
            progressBar1.Value = (int)startingFuel;
            var pic = pbAeroplane.Image;
            pic.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pbAeroplane.Image = pic;
            FormMap.ShortestPath.Reverse();
            pbAeroplane.BringToFront();
            for (int i = 0; i < FormMap.ShortestPath.Count - 1; i++)
            {
                var node2 = FormMap.ShortestPath[i + 1];
                var x1 = node2.Point.X * 890 - 7;
                var y1 = node2.Point.Y * 388 - 7;
                pbAeroplane.Location = new System.Drawing.Point((int)x1, (int)y1);
                newBomber.Fuel = newBomber.Fuel - (startingFuel / (FormMap.ShortestPath.Count * 2));
                progressBar1.Value = (int)newBomber.Fuel;
                Thread.Sleep(50);
                Update();
            }
        }
        DateTime bombTime = DateTime.Now;
        private void FinalReport(SearchEngine search)
        {
            pic = UserInterfaceV2.Resource1.Plane1;
            pic.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pbAeroplane.Image = pic;
            int damage = 0;
            string buildings = null;
            string bombs = newBomber.Bombs.ToString();
            string maxBombs = newBomber.MaxInventory.ToString();
            double fuelUsed = (search.ShortestRouteLength * 50 * 2);
            int distance = (int)(search.ShortestRouteLength * 50000);
            richTextBox1.Clear();
            richTextBox1.Text = $"Mission Complete\n" +
                $"Enemy Targets Destroyed: {newBomber.Bombs}\r\n" +
                $"Plane Used: {newBomber.Name}\r\n" +
                $"Bombs Used: {bombs}\r\n" +
                $"Fuel Used: {fuelUsed.ToString("0.00")}\r\n";
            foreach (EnemyBaseObj item in enemies)
            {
                if (item.Targeted == true)
                {
                    damage += item.Points;
                    buildings += item.Name + ",";
                }
            }
            dh.ReportWriter(damage, bombTime, buildings, (int)fuelUsed, maxBombs, bombs, 0, 0, distance);
        }
        #endregion

        private void btnAeroplane_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
