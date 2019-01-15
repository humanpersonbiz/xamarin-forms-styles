using System.Linq;
using Xamarin.Forms;

namespace Components.Theme
{
    public static class ThemeEffects
    {
        public static readonly BindableProperty
            CornerRadiusProperty = BindableProperty.CreateAttached(
                "CornerRadius",
                typeof(double),
                typeof(ThemeEffects),
                0.0,
                propertyChanged: OnChanged<CornerRadiusEffect, double>
            );

        private static void OnChanged<TEffect, TProp>(
            BindableObject bindable, object oldValue, object newValue
        ) where TEffect : Effect, new()
        {
            if (!(bindable is View view))
            {
                return;
            }

            if (Equals(newValue, default(TProp)))
            {
                var toRemove = view.Effects.FirstOrDefault(e => e is TEffect);
                if (toRemove != null)
                {
                    view.Effects.Remove(toRemove);
                }
            }
            else
            {
                view.Effects.Add(new TEffect());
            }
        }

        public static void SetCornerRadius(BindableObject view, double radius)
        {
            view.SetValue(CornerRadiusProperty, radius);
        }

        public static double GetCornerRadius(BindableObject view)
        {
            return (double)view.GetValue(CornerRadiusProperty);
        }

        private class CornerRadiusEffect : RoutingEffect
        {
            public CornerRadiusEffect() : base("Xamarin.CornerRadiusEffect") { }
        }
    }
}