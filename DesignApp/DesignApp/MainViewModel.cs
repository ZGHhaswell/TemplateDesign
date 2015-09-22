using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Input;
using System.Windows.Media.Animation;
using DesignApp.Data;
using DesignApp.Interface;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using Microsoft.Win32;

namespace DesignApp
{
    public class MainViewModel : BindableBase
    {
        #region 参数

        private string _param1;
        public string Param1
        {
            get
            {
                return _param1;
            }
            set
            {
                _param1 = value;
                OnPropertyChanged("Param1");
            }
        }

        private string _param1Value;
        public string Param1Value
        {
            get
            {
                return _param1Value;
            }
            set
            {
                _param1Value = value;
                OnPropertyChanged("Param1Value");
            }
        }

        private string _param2;
        public string Param2
        {
            get
            {
                return _param2;
            }
            set
            {
                _param2 = value;
                OnPropertyChanged("Param2");
            }
        }

        private string _param2Value;
        public string Param2Value
        {
            get
            {
                return _param2Value;
            }
            set
            {
                _param2Value = value;
                OnPropertyChanged("Param2Value");
            }
        }

        private string _param3;
        public string Param3
        {
            get
            {
                return _param3;
            }
            set
            {
                _param3 = value;
                OnPropertyChanged("Param3");
            }
        }

        private string _param3Value;
        public string Param3Value
        {
            get
            {
                return _param3Value;
            }
            set
            {
                _param3Value = value;
                OnPropertyChanged("Param3Value");
            }
        }

        private string _param4;
        public string Param4
        {
            get
            {
                return _param4;
            }
            set
            {
                _param4 = value;
                OnPropertyChanged("Param4");
            }
        }

        private string _param4Value;
        public string Param4Value
        {
            get
            {
                return _param4Value;
            }
            set
            {
                _param4Value = value;
                OnPropertyChanged("Param4Value");
            }
        }

        private string _param5;
        public string Param5
        {
            get
            {
                return _param5;
            }
            set
            {
                _param5 = value;
                OnPropertyChanged("Param5");
            }
        }

        private string _param5Value;
        public string Param5Value
        {
            get
            {
                return _param5Value;
            }
            set
            {
                _param5Value = value;
                OnPropertyChanged("Param5Value");
            }
        }

        private string _param6;
        public string Param6
        {
            get
            {
                return _param6;
            }
            set
            {
                _param6 = value;
                OnPropertyChanged("Param6");
            }
        }

        private string _param6Value;
        public string Param6Value
        {
            get
            {
                return _param6Value;
            }
            set
            {
                _param6Value = value;
                OnPropertyChanged("Param6Value");
            }
        }

        private string _param7;
        public string Param7
        {
            get
            {
                return _param7;
            }
            set
            {
                _param7 = value;
                OnPropertyChanged("Param7");
            }
        }

        private string _param7Value;
        public string Param7Value
        {
            get
            {
                return _param7Value;
            }
            set
            {
                _param7Value = value;
                OnPropertyChanged("Param7Value");
            }
        }

        private string _param8;
        public string Param8
        {
            get
            {
                return _param8;
            }
            set
            {
                _param8 = value;
                OnPropertyChanged("Param8");
            }
        }

        private string _param8Value;
        public string Param8Value
        {
            get
            {
                return _param8Value;
            }
            set
            {
                _param8Value = value;
                OnPropertyChanged("Param8Value");
            }
        }

        private string _param9;
        public string Param9
        {
            get
            {
                return _param9;
            }
            set
            {
                _param9 = value;
                OnPropertyChanged("Param9");
            }
        }

        private string _param9Value;
        public string Param9Value
        {
            get
            {
                return _param9Value;
            }
            set
            {
                _param9Value = value;
                OnPropertyChanged("Param9Value");
            }
        }

        #endregion

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

        private int pointCount = 0;

        public ICommand AddPointCommand { get; set; }

        private void AddPointCommandExecute()
        {
            var newPoint = new Point(PointX, PointY, 10);
            newPoint.Name = string.Format("Point{0}", ++pointCount);
            newPoint.XExpress = PointXExpress;
            newPoint.YExporess = PointYExpress;

            GraphSet.GraphObjects.Add(newPoint);

            Canvas.InvalidateVisual();
        }

        private bool _isHor = true;
        public bool IsHor
        {
            get
            {
                return _isHor;
            }
            set
            {
                _isHor = value;
                OnPropertyChanged("IsHor");
            }
        }

        private bool _isVer;
        public bool IsVer
        {
            get
            {
                return _isVer;
            }
            set
            {
                _isVer = value;
                OnPropertyChanged("IsVer");
            }
        }

        private int remartPointCount = 0;

        public ICommand AddRemartPointCommand { get; set; }

        private void AddRemartPointCommandExecute()
        {
            var newPoint = new RemartPoint(PointX, PointY, 10);
            newPoint.Name = string.Format("RemartPoint{0}", ++remartPointCount);
            newPoint.Orientation = IsHor ? Orientation.Hor : Orientation.Ver;
            newPoint.XExpress = PointXExpress;
            newPoint.YExporess = PointYExpress;

            GraphSet.GraphObjects.Add(newPoint);

            Canvas.InvalidateVisual();
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

            var newLine = new Line(lineA, lineB, 10);
            newLine.Name = string.Format("Line{0}", ++lineCount);
            
            GraphSet.GraphObjects.Add(newLine);

            Canvas.InvalidateVisual();
        }

        private int remartLineCount = 0;

        public ICommand AddRemartLineCommand { get; set; }

        private void AddRemartLineCommandExecute()
        {
            if (string.IsNullOrEmpty(LineA) || string.IsNullOrEmpty(LineB))
                return;

            var lineA = GraphSet.GraphObjects.FirstOrDefault(obj => string.Equals(LineA, obj.Name)) as RemartPoint;
            var lineB = GraphSet.GraphObjects.FirstOrDefault(obj => string.Equals(LineB, obj.Name)) as RemartPoint;

            if (lineA == null || lineB == null)
                return;

            var newLine = new RemartLine(lineA, lineB, 10);
            newLine.Name = string.Format("RemartLine{0}", ++remartLineCount);

            GraphSet.GraphObjects.Add(newLine);

            Canvas.InvalidateVisual();
        }

        private string _remartText = "实例";
        public string RemartText
        {
            get
            {
                return _remartText;
            }
            set
            {
                _remartText = value;
                OnPropertyChanged("RemartText");
            }
        }

        private string _remartTextExpress = "实例";
        public string RemartTextExpress
        {
            get
            {
                return _remartTextExpress;
            }
            set
            {
                _remartTextExpress = value;
                OnPropertyChanged("RemartTextExpress");
            }
        }

        private string _startPoint = "Point1";
        public string StartPoint
        {
            get
            {
                return _startPoint;
            }
            set
            {
                _startPoint = value;
                OnPropertyChanged("StartPoint");
            }
        }

        private int remartTextCount = 0;

        public ICommand AddRemartTextCommand { get; set; }

        private void AddRemartTextCommandExecute()
        {
            if (string.IsNullOrEmpty(RemartText))
                return;
            if (string.IsNullOrEmpty(RemartTextExpress))
                return;
            if (string.IsNullOrEmpty(StartPoint))
                return;

            var startPoint = GraphSet.GraphObjects.FirstOrDefault(obj => string.Equals(obj.Name, StartPoint)) as Point;

            if (startPoint == null)
                return;

            var newRemartText = new RemartText(startPoint, IsHor ? Orientation.Hor : Orientation.Ver, RemartText, 12);
            newRemartText.Name = string.Format("RemartText{0}", ++remartTextCount);

            GraphSet.GraphObjects.Add(newRemartText);

            Canvas.InvalidateVisual();

        }

        private string _templateName;
        public string TemplateName
        {
            get
            {
                return _templateName;
            }
            set
            {
                _templateName = value;
                OnPropertyChanged("TemplateName");
            }
        }

        public IList<string> Template { get; set; }

        public IList<string> ParamSet { get; set; }

        public IList<string> Points { get; set; }

        public IList<string> RemartPoints { get; set; }

        public IList<string> Lines { get; set; }

        public IList<string> RemartLines { get; set; }

        public IList<string> RemartTexts { get; set; }


        public IList<string> GraphObjects { get; set; }


        public ICommand CreateCodeCommand { get; set; }

        private void CreateCodeCommandExecute()
        {
            //var saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "*.cs";
            //saveFileDialog.FileName = string.Format("{0}.cs", TemplateName);

            //var dialogResult = saveFileDialog.ShowDialog();

            //if (dialogResult != null && dialogResult.Value)
            //{
            //    var fileName = saveFileDialog.FileName;


            //}
            GetCodeTempalte();
        }

        private void GetCodeTempalte()
        {
            var templateName = TemplateName;
            var graphObjs = GraphSet.GraphObjects.OrderBy(obj => obj.Order).ThenBy(obj => obj.Name);

            var newParams = new List<string>();
            LoadParam(newParams, Param1, Param1Value);
            LoadParam(newParams, Param2, Param2Value);
            LoadParam(newParams, Param3, Param3Value);
            LoadParam(newParams, Param4, Param4Value);
            LoadParam(newParams, Param5, Param5Value);
            LoadParam(newParams, Param6, Param6Value);
            LoadParam(newParams, Param7, Param7Value);
            LoadParam(newParams, Param8, Param8Value);
            LoadParam(newParams, Param9, Param9Value);

            var newPoints = new List<string>();

            var newLines = new List<string>();

            var newRemartPoints = new List<string>();

            var newRemartLines = new List<string>();

            var newRemartTexts = new List<string>();

            var newGraphObjes = new List<string>();

            foreach (var graphObject in graphObjs)
            {
                var point = graphObject as Point;
                var line = graphObject as Line;
                var remartPoint = graphObject as RemartPoint;
                var remartLine = graphObject as RemartLine;
                var remartText = graphObject as RemartText;

                if (remartPoint != null)
                {
                    LoadRemartPoint(newRemartPoints, remartPoint);
                }
                else if(point != null)
                {
                    LoadPoint(newPoints, point);
                }
                if (remartLine != null)
                {
                    LoadRemartLine(newRemartLines, remartLine);
                }
                else if (line != null)
                {
                    LoadLine(newLines, line);
                }
                
                if (remartText != null)
                {
                    LoadRemartText(newRemartTexts, remartText);
                }

                LoadGraphObj(newGraphObjes, graphObject);
            }

            //var template = Template;

            //template = template.Replace("$TemplateName$", TemplateName);
            //template = template.Replace("$ParamSet$", newParams.ToString());
            //template = template.Replace("$Points$", newPoints.ToString());
            //template = template.Replace("$RemartPoints$", newRemartPoints.ToString());
            //template = template.Replace("$Lines$", newLines.ToString());
            //template = template.Replace("$RemartLines$", newRemartLines.ToString());
            //template = template.Replace("$RemartText$", newRemartTexts.ToString());

            //File.WriteAllText("C:/Tempalte.cs", template);
        }

        private void LoadParam(IList<string> list, string param, string value)
        {
            if (!string.IsNullOrEmpty(param) && !string.IsNullOrEmpty(value))
            {
                foreach (var p in ParamSet)
                {
                    var newParam = p.Replace("$Param$", param);
                    newParam = newParam.Replace("$ParamValue$", value);

                    list.Add(newParam);
                    Trace.WriteLine(newParam);
                }
            }
        }

        private void LoadLine(IList<string> list, Line line)
        {
            foreach (var l in Lines)
            {
                var lineInfo = l.Replace("$Line$", line.Name);
                lineInfo = lineInfo.Replace("$PointX$", line.XPoint.Name);
                lineInfo = lineInfo.Replace("$PointY$", line.YPoint.Name);

                list.Add(lineInfo);
                Trace.WriteLine(lineInfo);
            }
        }

        private void LoadRemartLine(IList<string> list, RemartLine line)
        {
            foreach (var r in RemartLines)
            {
                var lineInfo = r.Replace("$RemartLine$", line.Name);
                lineInfo = lineInfo.Replace("$PointX$", line.XPoint.Name);
                lineInfo = lineInfo.Replace("$PointY$", line.YPoint.Name);

                list.Add(lineInfo);
                Trace.WriteLine(lineInfo);
            }
        }

        private void LoadPoint(IList<string> list, Point point)
        {
            foreach (var p in Points)
            {
                var pointInfo = p.Replace("$Point$", point.Name);
                pointInfo = pointInfo.Replace("$XExpress$", point.XExpress);
                pointInfo = pointInfo.Replace("$YExpress$", point.YExporess);
                list.Add(pointInfo);
                Trace.WriteLine(pointInfo);
            }
        }

        private void LoadRemartPoint(IList<string> list, RemartPoint point)
        {
            foreach (var r in RemartPoints)
            {
                var pointInfo = r.Replace("$RemartPoint$", point.Name);
                pointInfo = pointInfo.Replace("$XExpress$", point.XExpress);
                pointInfo = pointInfo.Replace("$YExpress$", point.YExporess);
                list.Add(pointInfo);

                Trace.WriteLine(pointInfo);
            }
            
        }

        private void LoadRemartText(IList<string> list, RemartText remartText)
        {
            foreach (var text in RemartTexts)
            {
                var remartTextInfo = text.Replace("$RemartText$", remartText.Name);
                remartTextInfo = remartTextInfo.Replace("$StartPoint$", remartText.StartPoint.Name);
                remartTextInfo = remartTextInfo.Replace("$Orientation$", string.Format("Orientation.{0}", remartText.Orientation.ToString()));
                remartTextInfo = remartTextInfo.Replace("$Express$", String.Format("{0}.ToString()", remartText.TextExpress));
                list.Add(remartTextInfo);
                Trace.WriteLine(remartTextInfo);
            }
            
        }

        private void LoadGraphObj(IList<string> list, GraphObject graphObject)
        {
            foreach (var o in GraphObjects)
            {
                var graphObj = o.Replace("$GraphObj$", graphObject.Name);
                list.Add(graphObj);

                Trace.WriteLine(graphObj);
            }
            
        }

        public ITempalte GraphSet { get; set; }


        public System.Windows.Controls.Canvas Canvas { get; set; }

        public MainViewModel()
        {
            GraphSet = new GraphSet();

            AddPointCommand = new DelegateCommand(AddPointCommandExecute);
            AddLineCommand = new DelegateCommand(AddLineCommandExecute);
            AddRemartPointCommand = new DelegateCommand(AddRemartPointCommandExecute);
            AddRemartLineCommand = new DelegateCommand(AddRemartLineCommandExecute);
            AddRemartTextCommand = new DelegateCommand(AddRemartTextCommandExecute);
            CreateCodeCommand = new DelegateCommand(CreateCodeCommandExecute);

            LoadTextTemplate();
        }

        private void LoadTextTemplate()
        {
            var path = Assembly.GetExecutingAssembly().Location;
            var fileInfo = new FileInfo(path);
            var directoryName = fileInfo.DirectoryName;

            var templatePath = Path.Combine(directoryName, "Template.txt");
            Template = Load(templatePath);

            var paramSetPath = Path.Combine(directoryName, "ParamSet.txt");
            ParamSet = Load(paramSetPath);

            var pointsPath = Path.Combine(directoryName, "Points.txt");
            Points = Load(pointsPath);

            var remartPointsPath = Path.Combine(directoryName, "RemartPoints.txt");
            RemartPoints = Load(remartPointsPath);

            var linesPath = Path.Combine(directoryName, "Lines.txt");
            Lines = Load(linesPath);

            var remartLinesPath = Path.Combine(directoryName, "RemartLines.txt");
            RemartLines = Load(remartLinesPath);

            var remartTextsPath = Path.Combine(directoryName, "RemartText.txt");
            RemartTexts = Load(remartTextsPath);

            var graphObjectPath = Path.Combine(directoryName, "GraphObjects.txt");
            GraphObjects = Load(graphObjectPath);
        }

        private IList<string> Load(string path)
        {
            var stringBuilder = new StringBuilder();

            var strs = File.ReadAllLines(path).ToList();

            return strs;
        }
    }
}
