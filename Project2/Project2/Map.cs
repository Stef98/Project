using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project2
{
    public partial class FormMap : Form
    {
        Results formResult = new Results();
        public static string jetName;
        public static int jetSpeed;
        public static int jetFuelLevel;
        public static int jetInventory;
        public static int jetDamage;
        public static int jetWeight;
        public static int jetHealth = int.Parse(PlaneSelect.ValueHealth);
        public static string status;
        public static int totDamage;
        
        public static int timeComplete;
     
        public static bool success = true;
        

        public static int oldEnemyHealth = 50;
        public static int enemyDamage = 5;
        public FormMap()
        {
            InitializeComponent();
            mapPanel.SendToBack();
            Jet.BringToFront();
        }
        
        private void FormMap_Load(object sender, EventArgs e)
        {
            totDamage = int.Parse(PlaneSelect.ValueDamage) * int.Parse(PlaneSelect.ValueInventory);

            labelName.Text = PlaneSelect.ValueName;
            lblHealth.Text = PlaneSelect.ValueHealth;
            jetSpeed = int.Parse(PlaneSelect.ValueSpeed);
            lblSpeed.Text = PlaneSelect.ValueSpeed;
            lblWeight.Text = PlaneSelect.ValueWeight;
            lblInventory.Text = PlaneSelect.ValueInventory;
            lblDamage.Text = totDamage.ToString();
         //lblFuel.Text = PlaneSelect.ValueFuel;
            jetFuelLevel = int.Parse(PlaneSelect.ValueFuel);

            //Allow objects to be droped
            PB_Armory.AllowDrop = true;
            PB_Barracks.AllowDrop = true;
            PB_OQ.AllowDrop = true;
            PB_MH.AllowDrop = true;
            PB_TD.AllowDrop = true;
            PB_Hospital.AllowDrop = true;
            PB_Storage.AllowDrop = true;
            PB_Turret.AllowDrop = true;

            //Allow drops on the locations
            //PB1.AllowDrop = true;
            //PB2.AllowDrop = true;
            //PB3.AllowDrop = true;
            //PB4.AllowDrop = true;
            //PB5.AllowDrop = true;
            //PB6.AllowDrop = true;
            //PB7.AllowDrop = true;
            //PB8.AllowDrop = true;

            ////to drop all objects
            //PB1.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB1.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB1.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB2.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB2.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB2.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB3.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB3.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB3.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB4.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB4.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB4.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB5.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB5.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB5.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB6.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB6.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB6.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB7.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB7.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB7.DragDrop += new DragEventHandler(PB_Armory_DragDrop);
            //PB8.MouseDown += new MouseEventHandler(PB_Armory_MouseDown);
            //PB8.DragEnter += new DragEventHandler(PB_Armory_DragEnter);
            //PB8.DragDrop += new DragEventHandler(PB_Armory_DragDrop);

            m_map[m_startPosX, m_startPosY] = 2;
            m_map[m_endPosX, m_endPosY] = 3;
           
        }
          
		
        //to drag armory
        private void PB_Armory_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_Armory_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PB_Armory_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag barracks
        private void PB_Barracks_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_Barracks_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            } 
        }

        private void PB_Barracks_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag office quaters
        private void PB_OQ_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);

        }

        private void PB_OQ_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PB_OQ_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag mess hall
        private void PB_MH_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);

        }

        private void PB_MH_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PB_MH_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag tank depo
        private void PB_TD_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_TD_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PB_TD_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag hospital
        private void PB_Hospital_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_Hospital_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            } 
        }

        private void PB_Hospital_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }

        //to drag Storage
        private void PB_Storage_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_Storage_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;

            }
        }

        private void PB_Storage_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

        }

        //to drag turret
        private void PB_Turret_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Select();
            pb.DoDragDrop(pb.Image, DragDropEffects.Copy);
        }

        private void PB_Turret_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Bitmap))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void PB_Turret_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox pb = (PictureBox)sender;
            pb.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);

        }


       
        private void Vertical_Tick(object sender, EventArgs e)
        {

            //int vdir = -3;
            //if (Jet2.Top < 0)
            //{
            //    vdir = +1 * jetSpeed;
            //}
            //else if (Jet2.Top > (this.Height - Jet2.Height - PB_Enemy.Height))
            //{
            //    vdir = -1 * jetSpeed;
            //}
            //else
            //{
            //    Jet2.Top += vdir * jetSpeed;

            //}

        }

            
        private void Horizontal_Tick(object sender, EventArgs e)
        {
            //int hdir = -3;
            //if (Jet2.Left < 0)
            //{
            //    hdir = +1 * jetSpeed;
            //}
            //else if (Jet2.Left > (this.Width - Jet.Width))
            //{
            //    hdir = -1 * jetSpeed;
            //}
            //else
            //{
            //    Jet2.Left += hdir * jetSpeed;
            //}
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //Graphics g = e.Graphics;
            //int numOfCells = 18;
            //int cellSize = 50;
            //Pen p = new Pen(Color.Black);

            //for (int y = 0; y < numOfCells; ++y)
            //{
            //    g.DrawLine(p, 0, y * cellSize, numOfCells * cellSize, y * cellSize);
            //}

            //for (int x = 0; x < numOfCells; ++x)
            //{
            //    g.DrawLine(p, x * cellSize, 0, x * cellSize, numOfCells * cellSize);
            //}

            m_graphics = mapPanel.CreateGraphics();
            int width = mapPanel.Width;
            int height = mapPanel.Height;
            for (int y = 0; y < 18; y++)
            {
                for (int x = 0; x < 18; x++)
                {
                    switch (m_map[x,y])
                    {
                        case 1:
                            m_graphics.DrawRectangle(Pens.White, x * width / 18, y * height / 18, 50, 50);
                           
                            break;
                        case 2:
                            m_graphics.DrawRectangle(Pens.Red, x * width / 18, y * height / 18, 50, 50);
                            break;
                        case 3:
                            m_graphics.DrawRectangle(Pens.Green, x * width / 18, y * height / 18, 50, 50);
                            break;
                        case 4:
                            m_graphics.DrawRectangle(Pens.Transparent, x * width / 18, y * height / 18, 50, 50);
                            break;
                        case 5:
                            m_graphics.DrawRectangle(Pens.Orange, x * width / 18, y * height / 18, 50, 50);

                            break;

                    }
                }
            }





        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PB_Enemy_Click(object sender, EventArgs e)
        {
            
        }

        struct MinPriorityQueue
        {
            public List<GraphEdge> m_edges;
            public List<int> m_costs;

            public GraphEdge Add(GraphEdge edge, int cost)
            {
                m_edges.Add(edge);
                m_costs.Add(cost);

                return edge;
            }

            public GraphEdge Pop()
            {
                //Pop the one with lowest priority
                int lowestPriority = int.MaxValue;
                int index = -1;
                for (int i = 0; i < m_edges.Count; i++)
                {
                    //Size should be the same as the cost list.
                    if (m_costs[i] < lowestPriority)
                    {
                        lowestPriority = m_costs[i];
                        index = i;
                    }
                }
                GraphEdge returnedEdge = m_edges[index];
                m_edges.RemoveAt(index);
                m_costs.RemoveAt(index);
                return returnedEdge;
            }
        }
        struct GraphEdge
        {

            public GraphEdge(int from, int to)
            {
                m_from = from;
                m_to = to;
            }
            public int m_from;//Connected nodes
            public int m_to;
            //public float m_cost;//Not used
        }
        struct GraphNode
        {

            public GraphNode(int index)
            {
                m_index = index;
                m_edges = new List<GraphEdge>();
            }
            public int m_index;
            public List<GraphEdge> m_edges;//adjacency list
        }
        struct NavGraph
        {
            public List<GraphNode> m_nodes;
            public List<int> AStarMethod(int sourceNode, int targetNode)
            {

                List<int> m_path = new List<int>();
                for (int y = 0; y < 64; y++)
                {
                    for (int x = 0; x < 64; x++)
                    {
                        m_path.Add(-1);
                    }
                }
                List<int> m_cost = new List<int>();
                for (int y = 0; y < 64; y++)
                {
                    for (int x = 0; x < 64; x++)
                    {
                        m_cost.Add(int.MaxValue);
                    }
                }

                List<GraphEdge> m_Traversed = new List<GraphEdge>();
                MinPriorityQueue minQ = new MinPriorityQueue();
                minQ.m_edges = new List<GraphEdge>();
                minQ.m_costs = new List<int>();

                m_cost[sourceNode] = 0;
                int targetX = targetNode % 64;
                int targetY = targetNode / 64;

                int sourceX = sourceNode % 64;
                int sourceY = sourceNode / 64;

                for (int i = 0; i < m_nodes[sourceNode].m_edges.Count; i++)
                {
                    GraphEdge edge = m_nodes[sourceNode].m_edges[i];
                    int nodeX = edge.m_to % 64;
                    int nodeY = edge.m_to / 64;

                    int heurCost = Math.Abs(nodeX - targetX) + Math.Abs(nodeY - targetY);
                    minQ.Add(edge, 1 + heurCost);
                }
                bool targetFound = false;
                while (minQ.m_edges.Count>0)
                {
                    GraphEdge curEdge = minQ.Pop();
                    m_Traversed.Add(curEdge);

                    if (m_cost[curEdge.m_to]>m_cost[curEdge.m_from]+1)
                    {
                        m_path[curEdge.m_to] = curEdge.m_from;
                        m_cost[curEdge.m_to] = m_cost[curEdge.m_from] + 1;
                        if (targetNode==curEdge.m_to)
                        {
                            targetFound = true;
                            break;
                        }
                        else
                        {
                            GraphNode curNode = m_nodes[curEdge.m_to];
                            for (int i = 0; i < curNode.m_edges.Count; i++)
                            {
                                if (m_Traversed.Contains(curNode.m_edges[i]))
                                {
                                    continue;
                                }
                                if (minQ.m_edges.Contains(curNode.m_edges[i]))
                                {
                                    continue;
                                }
                                int nodeX = curNode.m_edges[i].m_to % 64;
                                int nodeY = curNode.m_edges[i].m_to / 64;

                                int heuristicCost = Math.Abs(nodeX - targetX) + Math.Abs(nodeY - targetY);
                                minQ.Add(curNode.m_edges[i], m_cost[curNode.m_index] + 1 + heuristicCost);
                            }
                        }
                    }

                }
                if (targetFound) 
                {
                    return m_path;
                }
                else
                {
                    return null;
                }
            }
        }

        NavGraph m_graph;
        Graphics m_graphics = null;
        uint[,] m_map = new uint[64, 64];
        //coordinates of start
        int m_startPosX = 16;
        int m_startPosY = 15;
        //coordinates of end
        int m_endPosX = 1;                                                                                                                       
        int m_endPosY = 1;
       

        public void GenerateGraph()
        {
            m_graph.m_nodes = new List<GraphNode>();
            m_graph.m_nodes.Clear();
            for (int y = 0; y < 64; y++)
            {
                for (int x = 0; x < 64; x++)
                {
                    if (m_map[x, y] == 4 || m_map[x, y] == 5) 
                    {
                        m_map[x, y] = 0;
                    }
                    if (x == m_startPosX && y == m_startPosY)
                    {
                        m_map[x, y] = 2;
                    }
                    else if (x == m_endPosX && y == m_endPosY)
                    {
                        m_map[x, y] = 3;
                    }

                    GraphNode newNode = new GraphNode(x + y * 64);//index
                    if (y > 0) if (m_map[x, y - 1] != 1) newNode.m_edges.Add(new GraphEdge(newNode.m_index, newNode.m_index - 64));
                    if (y < 63) if (m_map[x, y + 1] != 1) newNode.m_edges.Add(new GraphEdge(newNode.m_index, newNode.m_index + 64));
                    if (x > 0) if (m_map[x - 1, y] != 1) newNode.m_edges.Add(new GraphEdge(newNode.m_index, newNode.m_index - 1));
                    if (x < 63) if (m_map[x + 1, y] != 1) newNode.m_edges.Add(new GraphEdge(newNode.m_index, newNode.m_index + 1));
                    m_graph.m_nodes.Add(newNode);
                }
            }
        }

        public void PaintPath(List<int> path)
        {
            if (path==null)
            {
                MessageBox.Show("No path availible");
            }
            else
            {
                for (int y = 0; y < 64; y++)
                {
                    for (int x = 0; x < 64; x++)
                    {
                        int nodeInt = path[x + y * 64];
                        if (nodeInt != -1)
                        {
                            m_map[x, y] = 4;//Path bit
                            
                            Horizontal.Start();
                            Vertical.Start();
                        }
                    }
                }
                int endNodeFrom = path[m_endPosX + 64 * m_endPosY];
                m_map[m_endPosX, m_endPosY] = 5;
                int newNodeFrom = path[endNodeFrom];
                while (path[newNodeFrom] != (m_startPosX + 64 * m_startPosY))
                {
                    //Paint 2d map
                    m_map[newNodeFrom % 64, newNodeFrom / 64] = 5;
                    //Assign 1d array;
                    newNodeFrom = path[newNodeFrom];
                }
            }
        }

        private void btnPlace_Click(object sender, EventArgs e)
        {
            GenerateGraph();
            m_map[(int)mPosX.Value, (int)mPosY.Value] = 1;
            mapPanel.Refresh();
        }

      

        private void fuelBarTimer_Tick(object sender, EventArgs e)
        {
            jetFuelLevel--;
            fuelLevelBar.PerformStep();
            if (jetFuelLevel ==0)
            {
                fuelBarTimer.Stop();
                Vertical.Stop();
                Horizontal.Stop();
                MessageBox.Show("Jet ran out of fuel and crashed","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                status = "Failed";
                jetName = labelName.Text;
                jetHealth = 0;
                success = false;
                formResult.Show();
                this.Hide();
            }
        }
        private void btnStart2_Click(object sender, EventArgs e)
        {
            GenerateGraph();
            List<int> path = m_graph.AStarMethod(m_startPosX + 64 * m_startPosY, m_endPosX + 64 * m_endPosY);
            PaintPath(path);
            mapPanel.Refresh();
            // Horizontal.Start();
            //  Vertical.Start();
            jetInventory = int.Parse(lblInventory.Text) * 1000;
            fuelLevelBar.Maximum = jetFuelLevel * 1000;
            fuelLevelBar.Step = 1000;
            fuelBarTimer = new Timer();
            fuelBarTimer.Tick += new EventHandler(fuelBarTimer_Tick);
            fuelBarTimer.Interval = 9000 - jetInventory;
            fuelBarTimer.Start();
        }
        public static int newEnemyHealth;
        public static int newjetHealth;
        public static int totEnemyDamageGive;

        private void btnDone_Click(object sender, EventArgs e)
        {
            fuelBarTimer.Stop();
            success = true;
            status = "Success";
            totDamage = int.Parse(PlaneSelect.ValueInventory) * int.Parse(PlaneSelect.ValueDamage);
            newEnemyHealth = oldEnemyHealth - totDamage;

            totEnemyDamageGive = (enemyDamage * 2);
            newjetHealth = jetHealth - totEnemyDamageGive;
            
            formResult.Show();
           // this.Hide();
        }
    }
	
}
