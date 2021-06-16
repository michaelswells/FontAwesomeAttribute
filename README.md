# FontAwesomeAttribute
FontAwesomeAttribute is a general-purpose attribute to specify user-visible globalizable strings for types and members.

## Usage
Add package reference to *.csproj
``` xml
  <ItemGroup>
    <PackageReference Include="FontAwesomeAttribute" Version="0.1.0.0" />
  </ItemGroup>
```

Add using statement in code
```cs
using FontAwesome.DataAnnotations;
```

Add attribute to enum
```cs
  public enum Role
  {
    /// <summary>
    /// No role assigned, default user role
    /// </summary>
    [Description("None")]
    [Display(Name = "None")]
    [FontAwesome(Name = "No Roles", FixedWidth = "True", Icon1 = FontAwesome.Css.Ban, IconSize1 = FontAwesome.Size.Normal, Stacked = "False")]
    None,

    /// <summary>
    /// Developer role
    /// </summary>
    [Description("Developer")]
    [Display(Name = "Developer")]
    [FontAwesome(Name = "Developer", FixedWidth = "True", Icon1 = FontAwesome.Css.UserNinja, IconSize1 = FontAwesome.Size.Normal, Stacked = "False")]
    Developer,
  }
```

Add an extension class for enums

**&copy;** for this code snippet [C# Using Extended Attribute Information on Objects](http://omegacoder.com/?p=28)
```cs
  /// <summary>
  /// Enum Extensions
  /// </summary>
  public static class EnumExtensions
  {
    #region Public Methods

    /// <summary>
    /// If an enum has a custom attrbute, this will return that attribute or null.
    /// </summary>
    /// <typeparam name="TCustomAttr">
    /// The type of the
    /// <code>custom attribute</code>
    /// to extract from the enum.
    /// </typeparam>
    /// <typeparam name="TEnum">The enum currently being viewed.</typeparam>
    /// <param name="instance">The instance.</param>
    /// <returns>The custom attribute (TCustomAttr) or null</returns>
    public static TCustomAttr ExtractAttribute<TCustomAttr, TEnum>(this TEnum instance)
    {
      if (instance != null)
      {
        try
        {
          FieldInfo fieldInfo = instance.GetType().GetField(instance.ToString());

          var attributes = fieldInfo.GetCustomAttributes(typeof(TCustomAttr), false).ToList();

          if (attributes.Any())
          {
            return (TCustomAttr)attributes[0];
          }
        }
        catch (Exception)
        {
        }
      }

      return default(TCustomAttr);
    }

    #endregion Public Methods
  }
```

Use in code
```cs
  string item = "Developer";
  Role role = (Enum.Parse<Role>(item, false));

  var faIconName = role.ExtractAttribute<FontAwesome.DataAnnotations.FontAwesomeAttribute, Role>().Css;
  var roleName = role.ExtractAttribute<System.ComponentModel.DataAnnotations.DisplayAttribute, Role>().Name;
```

Use in markup
```html
  <li class="navbar-light"><i class="@(faIconName) pe-4"></i>@roleName</li>
```

displays

<img src="developer.png"
     alt="developer fontAwesome icon with name"
     style="float: left; margin-right: 10px;" />

