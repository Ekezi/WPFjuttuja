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

namespace DrawShapes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            CreateBox(new BoxArea() { X = 50, Y = 50, Height = 100, Width = 80 });
            CreateBox(new BoxArea() { X = 200, Y = 200, Height = 40, Width = 200 });

            CreateCircle(new CircleArea() { X = 300, Y = 300, Radius = 50 });
            CreateCircle(new CircleArea() { X = 100, Y = 200, Radius = 100 });

            CreateTriangel(new TriangelArea() { X1 = 10, Y1 = 10, X2 = 10, Y2 = 10 });
            
            CreateDimond(new DiamondArea() { X1 = 150, Y1 = 150, X2 = 150, Y2 = 150 });

        }

        //Areas
        private class BoxArea
        {
            public int X;
            public int Y;
            public int Height;
            public int Width;
        }
        private class CircleArea
        {
            public int X;
            public int Y;
            public int Radius;
        }

        private class TriangelArea
        {
            public int X1;
            public int Y1;
            public int X2;
            public int Y2;
        }

        private class DiamondArea
        {
            public int X1;
            public int Y1;
            public int X2;
            public int Y2;
        }

        private void CreateBox(BoxArea box)
        {
            CreateLine(box.X, box.Y, box.X + box.Width, box.Y);
            CreateLine(box.X + box.Width, box.Y, box.X + box.Width, box.Y + box.Height);
            CreateLine(box.X, box.Y + box.Height, box.X + box.Width, box.Y + box.Height);
            CreateLine(box.X, box.Y, box.X, box.Y + box.Height);
        }

        private void CreateCircle(CircleArea circle)
        {
            Ellipse c = new Ellipse()
            {
                Width = circle.Radius * 2,
                Height = circle.Radius * 2,
                Stroke = Brushes.Red,
                StrokeThickness = 6
            };

            drawArea.Children.Add(c);

            c.SetValue(Canvas.LeftProperty, (double)circle.X);
            c.SetValue(Canvas.TopProperty, (double)circle.Y);
        }

        private void CreateTriangel(TriangelArea tri)
        {
            CreateLine(tri.X1 + 100, tri.Y1 + 0, tri.X2 + 200, tri.Y2 + 100);
            CreateLine(tri.X1 + 200, tri.Y1 + 100, tri.X2 + 10, tri.Y2 + 100);
            CreateLine(tri.X1 + 10, tri.Y1 + 100, tri.X2 + 100, tri.Y2 + 0);

        }

        private void CreateDimond(DiamondArea dia)
        {
            CreateLine(dia.X1 + 100, dia.Y1 + 10, dia.X2 + 200, dia.Y2 + 110);
            CreateLine(dia.X1 + 200, dia.Y1 + 110, dia.X2 + 100, dia.Y2 + 220);
            CreateLine(dia.X1 + 100, dia.Y1 + 220, dia.X2 + 0, dia.Y2 + 110);
            CreateLine(dia.X1 + 0, dia.Y1 + 110, dia.X2 + 100, dia.Y2 + 10);
        }


        /// <summary>  
        /// Creates a line at run-time  
        /// </summary>  
        private void CreateLine(double x1, double y1, double x2, double y2)
        {
            // Create a Line  
            Line redLine = new Line();
            redLine.X1 = x1;
            redLine.Y1 = y1;
            redLine.X2 = x2;
            redLine.Y2 = y2;

            // Create a red Brush  
            SolidColorBrush redBrush = new SolidColorBrush();
            redBrush.Color = Colors.Red;

            // Set Line's width and color  
            redLine.StrokeThickness = 4;
            redLine.Stroke = redBrush;

            // Add line to the Grid.  
            drawArea.Children.Add(redLine);
        }
    }
}
