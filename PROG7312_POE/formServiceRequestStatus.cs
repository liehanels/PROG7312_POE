using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ListView = System.Windows.Forms.ListView;

namespace PROG7312_POE
{
    public partial class formServiceRequestStatus : Form
    {
        public formServiceRequestStatus()
        {
            InitializeComponent();

            var tree = new Tree("Municipal Service Request");
            var requests = new List<ServiceRequest>
            {
                new ServiceRequest { Id = "001", Location = "Downtown", Category = "Water", Status = "Pending" },
                new ServiceRequest { Id = "002", Location = "City Center", Category = "Electricity", Status = "Completed" },
                new ServiceRequest { Id = "003", Location = "City Center", Category = "Electricity", Status = "Declined" },
                new ServiceRequest { Id = "004", Location = "Suburbs", Category = "Sanitation", Status = "In Progress" },
                new ServiceRequest { Id = "005", Location = "Downtown", Category = "Sanitation", Status = "In Progress" },
                new ServiceRequest { Id = "006", Location = "Downtown", Category = "Sanitation", Status = "In Progress" }
            };

            foreach (var request in requests)
            {
                tree.AddServiceRequest(request);
            }

            // Panel setup
            var panel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White
            };

            Controls.Add(panel);
            PaintTree(panel, tree.Root);
        }
        private void PaintTree(Panel panel, TreeNode root)
        {
            panel.Paint += (sender, e) =>
            {
                var graphics = e.Graphics;
                var pen = new Pen(Color.Black, 2);
                var font = new Font("Arial", 10);

                DrawNode(graphics, root, panel.Width / 2, 100, 0, pen, font);
            };
            panel.MouseClick += (sender, e) =>
            {
                HandleMouseClick(panel, e, root, panel.Width / 2, 100, 0);
            };
        }

        private void DrawNode(Graphics graphics, TreeNode node, int x, int y, int depth, Pen pen, Font font)
        {
            int offsetX = 280 - depth * 70; // Maintain current spacing
            const int offsetY = 120;
            const int radius = 20;

            // Define colors for different levels
            Color[] colors = { Color.Cyan, Color.LightGreen, Color.LightCoral, Color.Gray };
            Brush brush = new SolidBrush(colors[depth % colors.Length]);

            // Draw node
            graphics.FillEllipse(brush, x - radius / 2, y - radius / 2, radius, radius);
            // Draw text next to node
            graphics.DrawString(node.Name, font, Brushes.Black, x + radius / 2 + 10, y - radius / 2);

            // Draw children
            int childX = x - offsetX * (node.Children.Count - 1) / 2;
            foreach (var child in node.Children)
            {
                graphics.DrawLine(pen, x, y + radius / 2, childX, y + offsetY - radius / 2);
                DrawNode(graphics, child, childX, y + offsetY, depth + 1, pen, font);
                childX += offsetX;
            }
        }
        private void HandleMouseClick(Panel panel, MouseEventArgs e, TreeNode node, int x, int y, int depth)
        {
            int offsetX = 280 - depth * 70; // Maintain current spacing
            const int offsetY = 120;
            const int radius = 20;

            if (IsPointInCircle(e.X, e.Y, x, y, radius))
            {
                MessageBox.Show($"Node clicked: {node.Name}");
                return;
            }

            int childX = x - offsetX * (node.Children.Count - 1) / 2;
            foreach (var child in node.Children)
            {
                HandleMouseClick(panel, e, child, childX, y + offsetY, depth + 1);
                childX += offsetX;
            }
        }

        private bool IsPointInCircle(int px, int py, int cx, int cy, int radius)
        {
            int dx = px - cx;
            int dy = py - cy;
            return dx * dx + dy * dy <= radius * radius;
        }

    }
    public class TreeNode
    {
        public string Name { get; set; }
        public List<TreeNode> Children { get; set; }

        public TreeNode(string name)
        {
            Name = name;
            Children = new List<TreeNode>();
        }
        public void AddChild(TreeNode node)
        {
            Children.Add(node);
        }
    }
    public class  Tree
    {
        public TreeNode Root { get; set; }
        public Tree(string rootName)
        {
            Root = new TreeNode(rootName);
        }

        public void AddServiceRequest(ServiceRequest request)
        {
            TreeNode locationNode = FindOrCreateNode(Root, request.Location);
            TreeNode categoryNode = FindOrCreateNode(locationNode, request.Category);
            TreeNode statusNode = FindOrCreateNode(categoryNode, request.Status);
            statusNode.AddChild(new TreeNode(request.Id));
        }

        private TreeNode FindOrCreateNode(TreeNode parent, string nodeName)
        {
            foreach (var child in parent.Children)
            {
                if (child.Name == nodeName)
                {
                    return child;
                }
            }
            var newNode = new TreeNode(nodeName);
            parent.AddChild(newNode);
            return newNode;
        }
    }
    public class ServiceRequest
    {
        public string Id { get; set; }
        public string Location { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
    }
}
