using System.Linq;
using System.Windows.Input;
using DesignApp.Data;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;

namespace DesignApp
{
    public class MainViewModel : BindableBase
    {
        private int _pointX;
        public int PointX
        {
            get
            {
                return _pointX;
            }
            set
            {
                _pointX = value;
                OnPropertyChanged("PointX");
            }
        }

        private int _pointY;

        public int PointY
        {
            get
            {
                return _pointY;
            }
            set
            {
                _pointY = value;
                OnPropertyChanged("PointY");
            }
        }

        private string _pointXExpress;

        public string PointXExpress
        {
            get
            {
                return _pointXExpress;
            }
            set
            {
                _pointXExpress = value;
                OnPropertyChanged("PointXExpress");
            }
        }


        private string _pointYExpress;

        public string PointYExpress
        {
            get
            {
                return _pointYExpress;
            }
            set
            {
                _pointYExpress = value;
                OnPropertyChanged("PointYExpress");
            }
        }

        private string _lineA;

        public string LineA
        {
            get
            {
                return _lineA;
            }
            set
            {
                _lineA = value;
                OnPropertyChanged("LineA");
            }
        }

        private string _lineB;
        public string LineB
        {
            get
            {
                return _lineB;
            }
            set
            {
                _lineB = value;
                OnPropertyChanged("LineB");
            }
        }

        public ICommand AddPointCommand { get; set; }

        private int pointCount = 0;

        private void AddPointCommandExecute()
        {
            var newPoint = new Point();
            newPoint.Name = string.Format("Point{0}", ++pointCount);
            newPoint.X = PointX;
            newPoint.Y = PointY;
            newPoint.XExpress = PointXExpress;
            newPoint.YExporess = PointYExpress;

            GraphSet.GraphObjects.Add(newPoint);
        }

        private int lineCount = 0;

        public ICommand AddLineCommand { get; set; }

        private void AddLineCommandExecute()
        {
            if (string.IsNullOrEmpty(LineA) || string.IsNullOrEmpty(LineB))
                return;

            var lineA = GraphSet.GraphObjects.FirstOrDefault(obj => string.Equals(LineA, obj.Name)) as Point;
            var lineB = GraphSet.GraphObjects.FirstOrDefault(obj => string.Equals(LineB, obj.Name)) as Point;

            if (lineA == null || lineB == null)
                return;

            var newLine = new Line();
            newLine.Name = string.Format("Line{0}", ++lineCount);
            newLine.XPoint = lineA;
            newLine.YPoint = lineB;
            
            GraphSet.GraphObjects.Add(newLine);
        }

        public GraphSet GraphSet { get; set; }

        public MainViewModel()
        {
            GraphSet = new GraphSet();

            AddPointCommand = new DelegateCommand(AddPointCommandExecute);
            AddLineCommand = new DelegateCommand(AddLineCommandExecute);
        }
    }
}
