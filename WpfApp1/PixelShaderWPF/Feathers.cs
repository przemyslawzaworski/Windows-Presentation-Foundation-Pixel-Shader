using System;
using System.Windows.Media.Effects;
using System.Windows;
using System.Windows.Media;

namespace PixelShaderWPF
{
    public class Feathers : ShaderEffect
    {
        public static readonly DependencyProperty InputProperty = ShaderEffect.RegisterPixelShaderSamplerProperty("Input", typeof(Feathers), 0);

        public Brush Input
        {
            get => ((Brush)(GetValue(InputProperty)));
            set => SetValue(InputProperty, value);
        }

        public Feathers()
        {
            PixelShader pixelShader = new PixelShader { UriSource = new Uri(@"pack://application:,,,/PixelShaderWPF;component/feathers.ps") };
            PixelShader = pixelShader;
            UpdateShaderValue(InputProperty);
            UpdateShaderValue(TimeProperty);
        }

        public static readonly DependencyProperty TimeProperty = DependencyProperty.Register("time", typeof(double), typeof(Feathers), new PropertyMetadata(0.0, PixelShaderConstantCallback(0)));

        public double Timer
        {
            get => ((double)(this.GetValue(TimeProperty)));          
            set => this.SetValue(TimeProperty, value);            
        }
    }
}
