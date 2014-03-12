using System;
using System.Drawing;
using System.Windows.Forms;

namespace Life
{
    public sealed partial class GameOfLife : UserControl
    {
        private int _gridSize = 10;
        private int _width;
        private int _height;
        private bool[,] _world;
        private bool _state;


        public GameOfLife()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }

        public int Interval 
        {
            get { return timer.Interval; }
            set { timer.Interval = value; }
        }

        public bool Running
        {
            get { return timer.Enabled; }
            set { timer.Enabled = value; }
        }

        public int GridSize
        {
            get { return _gridSize; }
            set
            {
                if(value < 1)
                    throw new Exception("GridSize must be at least 1.");
                _gridSize = value;
                MovePopulation();
            }
        }

        public void Clear()
        {
            _width = Width/GridSize;
            _height = Height/GridSize;

            _world = new bool[_width,_height];

            Invalidate();
        }

        public void CycleLife()
        {
            var world = (bool[,])_world.Clone();

            for (var x = 0; x < _width; x++)
                for (var y = 0; y < _height; y++)
                {
                    var neighbors = CalculateNeighbors(x, y);
                    if (_world[x, y])
                    {
                        if (neighbors != 2 && neighbors != 3)
                            world[x, y] = false;
                    }
                    else
                    {
                        if (neighbors == 3)
                            world[x, y] = true;
                    }
                }

            _world = world;
            Invalidate();
        }

        private void MovePopulation()
        {
            var width = Width/GridSize;
            var height = Height/GridSize;

            var world = new bool[width, height];

            for(var x=0;x<Math.Min(width,_width);x++)
                for (var y = 0; y < Math.Min(height, _height); y++)
                    world[x, y] = _world[x, y];

            _width = width;
            _height = height;
            _world = world;

            Invalidate();
        }

        private bool IsFilled(int x, int y)
        {
            return x >= 0 
                && y >= 0 
                && x < _width 
                && y < _height 
                && _world[x, y];
        }

        private int CalculateNeighbors(int x, int y)
        {
            var neighbors = 0;

            if (IsFilled(x, y - 1)) neighbors++;
            if (IsFilled(x + 1, y - 1)) neighbors++;
            if (IsFilled(x + 1, y )) neighbors++;
            if (IsFilled(x + 1, y + 1)) neighbors++;
            if (IsFilled(x, y + 1)) neighbors++;
            if (IsFilled(x - 1, y + 1)) neighbors++;
            if (IsFilled(x - 1, y)) neighbors++;
            if (IsFilled(x - 1, y - 1)) neighbors++;


            return neighbors;
        }

        protected override void OnLoad(EventArgs e)
        {
            Clear();

            base.OnLoad(e);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            MovePopulation();
           
            base.OnSizeChanged(e);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var sb = new SolidBrush(ForeColor);
            e.Graphics.Clear(BackColor);

            if (_world != null)
                for (var x = 0; x < _width; x++)
                    for (var y = 0; y < _height; y++)
                        if (_world[x, y])
                            e.Graphics.FillRectangle(sb, x*GridSize, y*GridSize, GridSize, GridSize);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {   
            if (e.Button == MouseButtons.Left)
            {
                var x = e.X/GridSize;
                var y = e.Y/GridSize;

                if (x < 0 || y < 0 || x >= _width || y >= _height)
                    return;

                _world[x, y] = _state = !_world[x, y];

                Invalidate();

                return;
            }

            base.OnMouseDown(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var x = e.X / GridSize;
                var y = e.Y / GridSize;

                if (x < 0 || y < 0 || x >= _width || y >= _height)
                    return;

                _world[x, y] = _state;

                Invalidate();

                return;
            }

            base.OnMouseMove(e);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            CycleLife();
        }
    }
}
