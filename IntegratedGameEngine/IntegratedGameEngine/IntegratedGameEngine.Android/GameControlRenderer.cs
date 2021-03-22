using Game;
using IntegratedGameEngine;
using IntegratedGameEngine.Android;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Android.Views.View;

[assembly: ExportRenderer(typeof(GameControl), typeof(GameControlRenderer))]

namespace IntegratedGameEngine.Android
{
    public class GameControlRenderer : ViewRenderer<GameControl, View>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<GameControl> e)
        {
            base.OnElementChanged(e);

            var game = new TestGame();
            var view = game.Services.GetService(typeof(View)) as View;

            e.NewElement.Content = view.ToView();
            game.Run();
        }
    }
}
