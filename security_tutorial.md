creating a restricted access page with PageTemplate_WithSecurity :

1 - copy the RoleSelector propertytype and the roleSelectorPropertyEditor in your propertytypes folder
2 - inside your page type add this line : 
		
		<[Property]("Role")> _
        Public Overridable Property Role As RoleSelectorProperty

		this property will carry the access rules for this page
		
3 - copy the extensions/page/PageTemplate_WithSecurity.vb in your project
	this overloaded class include the necessary plumbing code for securing your page
	
4 - When creating your page,  instead of creating one  inherited from  PageTemplate , replace with PageTemplate_WithSecurity

5 - in admin section , configure the role with the new property
	et voila !
	