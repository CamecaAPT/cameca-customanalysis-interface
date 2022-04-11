using System.Windows.Media;

namespace Cameca.CustomAnalysis.Interface.View;

public record ColorStop(Color BottomColor, float RelativePosition, Color TopColor);