//--------------------------------------------------------------------------------------------------
// <auto-generated>
//
//     This code was generated by code generator tool.
//
//     To customize the code use your own partial class. For more info about how to use and customize
//     the generated code see the documentation at http://docs.kentico.com.
//
// </auto-generated>
//--------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

using CMS;
using CMS.Base;
using CMS.Helpers;
using CMS.DataEngine;
using CMS.DocumentEngine.Types.MedioClinic;
using CMS.DocumentEngine;

[assembly: RegisterDocumentType(OfficeLocations.CLASS_NAME, typeof(OfficeLocations))]

namespace CMS.DocumentEngine.Types.MedioClinic
{
	/// <summary>
	/// Represents a content item of type OfficeLocations.
	/// </summary>
	public partial class OfficeLocations : TreeNode
	{
		#region "Constants and variables"

		/// <summary>
		/// The name of the data class.
		/// </summary>
		public const string CLASS_NAME = "MedioClinic.OfficeLocations";


		/// <summary>
		/// The instance of the class that provides extended API for working with OfficeLocations fields.
		/// </summary>
		private readonly OfficeLocationsFields mFields;

		#endregion


		#region "Properties"

		/// <summary>
		/// OfficeLocationsID.
		/// </summary>
		[DatabaseIDField]
		public int OfficeLocationsID
		{
			get
			{
				return ValidationHelper.GetInteger(GetValue("OfficeLocationsID"), 0);
			}
			set
			{
				SetValue("OfficeLocationsID", value);
			}
		}


		/// <summary>
		/// Field Name.
		/// </summary>
		[DatabaseField]
		public string FolderName
		{
			get
			{
				return ValidationHelper.GetString(GetValue("FolderName"), @"");
			}
			set
			{
				SetValue("FolderName", value);
			}
		}


		/// <summary>
		/// Gets an object that provides extended API for working with OfficeLocations fields.
		/// </summary>
		[RegisterProperty]
		public OfficeLocationsFields Fields
		{
			get
			{
				return mFields;
			}
		}


		/// <summary>
		/// Provides extended API for working with OfficeLocations fields.
		/// </summary>
		[RegisterAllProperties]
		public partial class OfficeLocationsFields : AbstractHierarchicalObject<OfficeLocationsFields>
		{
			/// <summary>
			/// The content item of type OfficeLocations that is a target of the extended API.
			/// </summary>
			private readonly OfficeLocations mInstance;


			/// <summary>
			/// Initializes a new instance of the <see cref="OfficeLocationsFields" /> class with the specified content item of type OfficeLocations.
			/// </summary>
			/// <param name="instance">The content item of type OfficeLocations that is a target of the extended API.</param>
			public OfficeLocationsFields(OfficeLocations instance)
			{
				mInstance = instance;
			}


			/// <summary>
			/// OfficeLocationsID.
			/// </summary>
			public int ID
			{
				get
				{
					return mInstance.OfficeLocationsID;
				}
				set
				{
					mInstance.OfficeLocationsID = value;
				}
			}


			/// <summary>
			/// Field Name.
			/// </summary>
			public string FolderName
			{
				get
				{
					return mInstance.FolderName;
				}
				set
				{
					mInstance.FolderName = value;
				}
			}
		}

		#endregion


		#region "Constructors"

		/// <summary>
		/// Initializes a new instance of the <see cref="OfficeLocations" /> class.
		/// </summary>
		public OfficeLocations() : base(CLASS_NAME)
		{
			mFields = new OfficeLocationsFields(this);
		}

		#endregion
	}
}