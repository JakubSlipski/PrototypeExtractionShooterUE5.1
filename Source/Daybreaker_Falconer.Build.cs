using UnrealBuildTool;

public class Daybreaker_Falconer : ModuleRules
{
	public Daybreaker_Falconer(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PrivateDependencyModuleNames.Add("Core");
		PrivateDependencyModuleNames.Add("Core");
	}
}
