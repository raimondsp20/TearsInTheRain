using UnrealBuildTool;

public class TearsInTheRainTarget : TargetRules
{
	public TearsInTheRainTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("TearsInTheRain");
	}
}
