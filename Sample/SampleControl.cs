using SharpDX;
using SharpDX.Direct2D1;
using SharpDX.Mathematics.Interop;
using System;

namespace Sample
{
    class SampleControl : D2dControl.D2dControl
    {

        private float x = 0;
        private float y = 0;
        private float w = 10;
        private float h = 20;
        private float dx = 10;
        private float dy = 10;

        private Random rnd = new Random();

        public SampleControl()
        {
            resCache.Add("RedBrush", t => new SolidColorBrush(t, new RawColor4(1.0f, 0.0f, 0.0f, 1.0f)));
            resCache.Add("GreenBrush", t => new SolidColorBrush(t, new RawColor4(0.0f, 1.0f, 0.0f, 1.0f)));
            resCache.Add("BlueBrush", t => new SolidColorBrush(t, new RawColor4(0.0f, 0.0f, 1.0f, 1.0f)));
        }

        public override void Render(RenderTarget target)
        {
            target.Clear(new RawColor4(1.0f, 1.0f, 1.0f, 0f));
            Brush brushGreen = resCache["GreenBrush"] as Brush;
            Brush brushBlue = resCache["BlueBrush"] as Brush;

            target.FillRectangle(new RawRectangleF(x, y, x + w, y + h), brushGreen);
            RawVector2 vector2 = new RawVector2()
            {
                X = x + 30,
                Y = y + 30,
            };
            target.FillEllipse(new Ellipse(vector2, h, h), brushBlue);

            x = x + dx;
            y = y + dy;
            if (x >= ActualWidth - w || x <= 0)
            {
                dx = -dx;
            }
            if (y >= ActualHeight - h || y <= 0)
            {
                dy = -dy;
            }
        }
    }
}
