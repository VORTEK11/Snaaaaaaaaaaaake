using ConsoleSnake.Helpers;
using System;
using System.Collections.Generic;

namespace ConsoleSnake.Components
{

    public sealed class Walls
    {
        private List<Line> _walls;

        private static readonly Lazy<Walls> instance =
                      new Lazy<Walls>(() => new Walls());

        public static Walls Instance { get => instance.Value; }

        private Walls()
        {
            _walls = new List<Line>()
            {
                new Line(0, Constants.WallsWidth, 0, '-', "horizontal"),
                new Line(0, Constants.WallsWidth, Constants.WallsHeight, '-', "horizontal"),
                new Line(0, Constants.WallsHeight, 0, '|', "vertical"),
                new Line(0, Constants.WallsHeight, Constants.WallsWidth, '|', "vertical"),
            };
        }

        public void Draw()
        {
            this._walls.ForEach(w => w.Draw());
        }

        public bool IsHit(Point withPoint)
        {
            bool isHit = false;
            try
            { 
                this._walls.ForEach(w =>
                {
                    w.PointsToDraw.ForEach(p => {
                        if (p.IsHit(withPoint))
                            isHit = true;
                    });
                });
                
            }
            catch(NullReferenceException)
            {
                throw new NullReferenceException("Trying to access component which is still not created.");
            }
            return isHit;
        }

    }
}
