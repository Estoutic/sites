using System;
using System.Windows.Forms;

namespace GravityBalls
{
    public class WorldModel
    {
        public double BallX;
        public double BallY;
        public double BallRadius;
        public double WorldWidth;
        public double WorldHeight;

        public double BallVx = 400;
        public double BallVy = 300;
        public double Resistance = 0.2;
        public double G = 500;
        public double Force = 300000;

        public void SimulateTimeframe(double dt)
        {
            MoveBall(dt);
            ApplyWallsBouncing();
            ApplyAirResistance(dt);
            ApplyGravity(dt);
            ApplyCursorRepulsion(dt);
        }

        private void MoveBall(double dt)
        {
            BallX += BallVx * dt;
            BallY += BallVy * dt;

            BallX = Math.Max(BallRadius, Math.Min(BallX, WorldWidth - BallRadius));
            BallY = Math.Max(BallRadius, Math.Min(BallY, WorldHeight - BallRadius));
        }

        private void ApplyWallsBouncing()
        {
            if (BallX + BallRadius >= WorldWidth || BallX - BallRadius <= 0)
                BallVx = -BallVx;

            if (BallY + BallRadius >= WorldHeight || BallY - BallRadius <= 0)
                BallVy = -BallVy;
        }

        private void ApplyAirResistance(double dt)
        {
            BallVx = BallVx - BallVx * Resistance * dt;
            BallVy = BallVy - BallVy * Resistance * dt;
        }

        private void ApplyGravity(double dt)
        {
            BallVy += G * dt;
        }

        private void ApplyCursorRepulsion(double dt)
        {
            var cursorX = Cursor.Position.X;
            var cursorY = Cursor.Position.Y;

            var dx = BallX - cursorX;
            var dy = BallY - cursorY;

            var d = Math.Sqrt(dx * dx + dy * dy);

            if (d > 1)  // защита от деления на ноль
            {
                var f = Force / (d * d);

                BallVx += dx * f * dt;
                BallVy += dy * f * dt;
            }
        }
    }
}