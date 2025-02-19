#pragma warning disable CS1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: Microsoft.Xrm.Sdk.Client.ProxyTypesAssemblyAttribute()]

namespace D365.Plugins.Entities
{
	
	
	/// <summary>
	/// Represents a source of entities bound to a Dataverse service. It tracks and manages changes made to the retrieved entities.
	/// </summary>
	public partial class OrgContext : Microsoft.Xrm.Sdk.Client.OrganizationServiceContext
	{
		
		/// <summary>
		/// Constructor.
		/// </summary>
		public OrgContext(Microsoft.Xrm.Sdk.IOrganizationService service) : 
				base(service)
		{
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="D365.Plugins.Entities.Account"/> entities.
		/// </summary>
		public System.Linq.IQueryable<D365.Plugins.Entities.Account> AccountSet
		{
			get
			{
				return this.CreateQuery<D365.Plugins.Entities.Account>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="D365.Plugins.Entities.Appointment"/> entities.
		/// </summary>
		public System.Linq.IQueryable<D365.Plugins.Entities.Appointment> AppointmentSet
		{
			get
			{
				return this.CreateQuery<D365.Plugins.Entities.Appointment>();
			}
		}
		
		/// <summary>
		/// Gets a binding to the set of all <see cref="D365.Plugins.Entities.Contact"/> entities.
		/// </summary>
		public System.Linq.IQueryable<D365.Plugins.Entities.Contact> ContactSet
		{
			get
			{
				return this.CreateQuery<D365.Plugins.Entities.Contact>();
			}
		}
	}
}
#pragma warning restore CS1591
