namespace AndroidApp1.drawables;

public class StepsCircleDrawable : IDrawable
{
    public int Steps { get; set; }
    public int Goal { get; set; }

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        float radius = (float)Math.Min(dirtyRect.Width, dirtyRect.Height) / 2f;
        float centerX = dirtyRect.Center.X;
        float centerY = dirtyRect.Center.Y;

        // Background circle
        canvas.StrokeColor = Colors.LightGray;
        canvas.StrokeSize = 20;
        canvas.DrawCircle(centerX, centerY, radius - 10);

        // Progress circle
        float progress = (float)Steps / Goal;
        float endAngle = 360 * progress;

        canvas.StrokeColor = Color.FromArgb("#4CAF50");
        canvas.StrokeSize = 20;
        canvas.DrawArc(centerX - (radius - 10), centerY - (radius - 10), (radius - 10)*2, (radius - 10)*2, 0, endAngle, true, false);
    }
}