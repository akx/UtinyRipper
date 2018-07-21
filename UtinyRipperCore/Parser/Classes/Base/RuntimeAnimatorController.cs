﻿using UtinyRipper.AssetExporters;
using UtinyRipper.Exporter.YAML;

namespace UtinyRipper.Classes
{
	public abstract class RuntimeAnimatorController : NamedObject
	{
		protected RuntimeAnimatorController(AssetInfo assetInfo) :
			base(assetInfo)
		{
		}

		public override void Read(AssetStream stream)
		{
			base.Read(stream);
		}

		public abstract bool IsContainsAnimationClip(AnimationClip clip);

		protected override YAMLMappingNode ExportYAMLRoot(IExportContainer container)
		{
			return base.ExportYAMLRoot(container);
		}
	}
}
