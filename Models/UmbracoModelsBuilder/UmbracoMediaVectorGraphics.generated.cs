//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco9_Blazor.Models.UmbracoModelsBuilder
{
	/// <summary>Vector Graphics (SVG)</summary>
	[PublishedModel("umbracoMediaVectorGraphics")]
	public partial class UmbracoMediaVectorGraphics : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new const string ModelTypeAlias = "umbracoMediaVectorGraphics";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<UmbracoMediaVectorGraphics, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public UmbracoMediaVectorGraphics(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Size: in bytes
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("umbracoBytes")]
		public virtual long UmbracoBytes => this.Value<long>(_publishedValueFallback, "umbracoBytes");

		///<summary>
		/// Type
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("umbracoExtension")]
		public virtual string UmbracoExtension => this.Value<string>(_publishedValueFallback, "umbracoExtension");

		///<summary>
		/// Vector Graphics
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.0-rc001+4f06c1f33a54daf4752a439778626202960db68c")]
		[ImplementPropertyType("umbracoFile")]
		public virtual string UmbracoFile => this.Value<string>(_publishedValueFallback, "umbracoFile");
	}
}
