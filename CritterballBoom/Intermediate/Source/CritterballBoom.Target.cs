using UnrealBuildTool;

public class CritterballBoomTarget : TargetRules
{
	public CritterballBoomTarget(TargetInfo Target) : base(Target)
	{
		DefaultBuildSettings = BuildSettingsVersion.V2;
		Type = TargetType.Game;
		ExtraModuleNames.Add("CritterballBoom");
	}
}
