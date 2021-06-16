using System;

namespace FontAwesome.DataAnnotations
{
  /// <summary>
  /// FontAwesomeAttribute is a general-purpose attribute to specify
  /// user-visible globalizable strings for types and members. The string
  /// properties of this class can be used as literals
  /// </summary>
  [AttributeUsage(
      AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.Method | AttributeTargets.Class,
      AllowMultiple = false)]
  public sealed class FontAwesomeAttribute : Attribute
  {
    #region Member Fields
#if NETSTANDARD2_0
    private string? _css = nameof(Css);
    private string? _fixedWidth = nameof(FixedWidth);
    private string? _icon1 = nameof(Icon1);
    private string? _icon2 = nameof(Icon2);
    private string? _iconColor1 = nameof(IconColor1);
    private string? _iconColor2 = nameof(IconColor2);
    private string? _iconCss1 = nameof(IconCss1);
    private string? _iconCss2 = nameof(IconCss2);
    private string? _iconSize1 = nameof(IconSize1);
    private string? _iconSize2 = nameof(IconSize2);
    private string? _iconStackSize1 = nameof(IconStackSize1);
    private string? _iconStackSize2 = nameof(IconStackSize2);
    private string? _iconStyle1 = nameof(IconStyle1);
    private string? _iconStyle2 = nameof(IconStyle2);
    private string? _name = nameof(Name);
    private string? _stacked = nameof(Stacked);
    private string? _stackSize = nameof(StackSize);
#else
    private string? _css = new string(nameof(Css));
    private string? _fixedWidth = new string(nameof(FixedWidth));
    private string? _icon1 = new string(nameof(Icon1));
    private string? _icon2 = new string(nameof(Icon2));
    private string? _iconColor1 = new string(nameof(IconColor1));
    private string? _iconColor2 = new string(nameof(IconColor2));
    private string? _iconCss1 = new string(nameof(IconCss1));
    private string? _iconCss2 = new string(nameof(IconCss2));
    private string? _iconSize1 = new string(nameof(IconSize1));
    private string? _iconSize2 = new string(nameof(IconSize2));
    private string? _iconStackSize1 = new string(nameof(IconStackSize1));
    private string? _iconStackSize2 = new string(nameof(IconStackSize2));
    private string? _iconStyle1 = new string(nameof(IconStyle1));
    private string? _iconStyle2 = new string(nameof(IconStyle2));
    private string? _name = new string(nameof(Name));
    private string? _stacked = new string(nameof(Stacked));
    private string? _stackSize = new string(nameof(StackSize));
#endif
    #endregion Member Fields

    #region All Constructors

    #endregion All Constructors

    #region Properties

    public string? Css
    {
      get
      {
        System.Text.StringBuilder sb = new System.Text.StringBuilder(string.Empty);
        sb.Append($"{GetIconStyle1()}");
        sb.Append($" {GetIcon1()}");
        sb.Append($" { GetIconColor1()}");
        sb.Append($" {GetIconSize1()}");
        sb.Append($" {GetFixedWidth()}");

        return sb.ToString().Replace("  ", " ");
      }
    }

    /// <summary>
    /// Gets or sets the FixedWidth attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetFixedWidth"/> method to retrieve
    /// the UI display string.
    /// </para>
    /// </summary>
    public string? FixedWidth
    {
      get
      {
        return _fixedWidth;
      }
      set => _fixedWidth = value;
    }

    /// <summary>
    /// Gets or sets the Icon1 attribute property, which may be a resource key string.
    /// <para>
    /// Consumers must use the <see cref="GetIcon1"/> method to retrieve the UI
    /// display string.
    /// </para>
    /// </summary>
    public string? Icon1
    {
      get => _icon1;
      set => _icon1 = value;
    }

    /// <summary>
    /// Gets or sets the Icon2 attribute property, which may be a resource key string.
    /// <para>
    /// Consumers must use the <see cref="GetIcon2"/> method to retrieve the UI
    /// display string.
    /// </para>
    /// </summary>
    public string? Icon2
    {
      get
      {
        //if (string.IsNullOrWhiteSpace(_icon1))
        //{
        //  throw new InvalidOperationException($"Property not set [{nameof(_icon1)}, {nameof(_icon1)}]");
        //}

        return _icon2;
      }
      set => _icon2 = value;
    }

    /// <summary>
    /// Gets or sets the IconColor1 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconColor1"/> method to retrieve
    /// the UI display string.
    /// </para>
    /// </summary>
    public string? IconColor1
    {
      get => _iconColor1;
      set => _iconColor1 = value;
    }

    /// <summary>
    /// Gets or sets the IconColor2 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconColor2"/> method to retrieve
    /// the UI display string.
    /// </para>
    /// </summary>
    public string? IconColor2
    {
      get
      {
        //if (string.IsNullOrWhiteSpace(_iconColor1))
        //{
        //  throw new InvalidOperationException($"Property not set [{nameof(_iconColor1)}, {nameof(_iconColor1)}]");
        //}

        return _icon2;
      }
      set => _iconColor2 = value;
    }

    /// <summary>
    /// Gets or sets the IconCss1 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconCss1"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? IconCss1
    {
      get => _iconCss1;
      set => _iconCss1 = value;
    }

    /// <summary>
    /// Gets or sets the IconCss2 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconCss2"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? IconCss2
    {
      get
      {
        //if (string.IsNullOrWhiteSpace(_iconCss1))
        //{
        //  throw new InvalidOperationException($"Property not set [{nameof(_iconCss1)}, {nameof(_iconCss1)}]");
        //}

        return _icon2;
      }
      set => _iconCss2 = value;
    }

    /// <summary>
    /// Gets or sets the IconSize1 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconSize1"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? IconSize1
    {
      get => _iconSize1;
      set => _iconSize1 = value;
    }

    /// <summary>
    /// Gets or sets the IconSize2 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconSize2"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? IconSize2
    {
      get
      {
        //if (string.IsNullOrWhiteSpace(_iconSize1))
        //{
        //  throw new InvalidOperationException($"Property not set [{nameof(_iconSize1)}, {nameof(_iconSize1)}]");
        //}

        return _iconSize2;
      }
      set => _iconSize2 = value;
    }

    /// <summary>
    /// Gets or sets the IconStackSize1 attribute property, which may be a
    /// resource key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconStackSize1"/> method to
    /// retrieve the UI display string.
    /// </para>
    /// </summary>
    public string? IconStackSize1
    {
      get => _iconStackSize1;
      set => _iconStackSize1 = value;
    }

    /// <summary>
    /// Gets or sets the IconStackSize2 attribute property, which may be a
    /// resource key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconStackSize2"/> method to
    /// retrieve the UI display string.
    /// </para>
    /// </summary>
    public string? IconStackSize2
    {
      get
      {
        //if (string.IsNullOrWhiteSpace(_iconStackSize1))
        //{
        //  throw new InvalidOperationException($"Property not set [{nameof(_iconStackSize1)}, {nameof(_iconStackSize1)}]");
        //}

        return _iconStackSize2;
      }
      set => _iconStackSize2 = value;
    }

    /// <summary>
    /// Gets or sets the IconStyle1 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconStyle1"/> method to retrieve
    /// the UI display string.
    /// </para>
    /// </summary>
    public string? IconStyle1
    {
      get => _iconStyle1;
      set => _iconStyle1 = value;
    }

    /// <summary>
    /// Gets or sets the IconStyle2 attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetIconStyle2"/> method to retrieve
    /// the UI display string.
    /// </para>
    /// </summary>
    public string? IconStyle2
    {
      get => _iconStyle2;
      set => _iconStyle2 = value;
    }

    /// <summary> Gets or sets the Name attribute property, which may be a
    /// resource key string. <para> Consumers must use the <see cref="GetName"/>
    /// method to retrieve the UI display string. </para>
    public string? Name
    {
      get => _name;
      set => _name = value;
    }

    public string? Stack
    {
      get
      {
        System.Text.StringBuilder sb = new System.Text.StringBuilder(string.Empty);

        if (Stacked!.ToLower().Equals("true"))
        {
          if (!_icon2!.Equals(nameof(Icon2)))
          {
            sb.Append($"<span class=\"fa-stack {GetIconSize2()}\">");
            sb.Append($"<i class=\"{GetIconStyle1()} {GetIcon1()} {GetIconStackSize1()}\"></i>");
            sb.Append($"<i class=\"{GetIconStyle2()} {GetIcon2()} {GetIconStackSize2()}\"></i>");
            sb.Append($"{GetName()}</span>");
          }
        }
        else
        {
          sb.Append($"<i class=\"{GetIconStyle1()} {GetIcon1()} {GetIconSize1()}\">{GetName()}</i>");
        }
        return sb.ToString().Replace("  ", " ");
      }
    }

    /// <summary>
    /// Gets or sets the Stacked attribute property, which may be a resource key string.
    /// <para>
    /// Consumers must use the <see cref="GetStacked"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? Stacked
    {
      get => _stacked;
      set => _stacked = value;
    }

    /// <summary>
    /// Gets or sets the StackSize attribute property, which may be a resource
    /// key string.
    /// <para>
    /// Consumers must use the <see cref="GetStackSize"/> method to retrieve the
    /// UI display string.
    /// </para>
    /// </summary>
    public string? StackSize
    {
      get => _stackSize;
      set => _stackSize = value;
    }

    public string? StackWithColorStyle
    {
      get
      {
        System.Text.StringBuilder sb = new System.Text.StringBuilder(string.Empty);

        if (Stacked!.ToLower().Equals("true"))
        {
          if (!_icon2!.Equals(nameof(Icon2)))
          {
            sb.Append($"<span class=\"fa-stack {GetIconSize2()}\">");
            sb.Append($"<i class=\"{GetIconStyle1()} {GetIcon1()} {GetIconStackSize1()}\" style=\"color: {GetIconColor1()};\"></i>");
            sb.Append($"<i class=\"{GetIconStyle2()} {GetIcon2()} {GetIconStackSize2()}\" style=\"color: {GetIconColor2()};\"></i>");
            sb.Append($"{GetName()}</span>");
          }
        }
        else
        {
          sb.Append($"<i class=\"{GetIconStyle1()} {GetIcon1()} {GetIconSize1()}\" style=\"color: {GetIconColor1()};\">{GetName()}</i>");
        }
        return sb.ToString().Replace("  ", " ");
      }
    }

#endregion Properties

#region Methods

    /// <summary>
    /// Gets the UI display string for FixedWidth.
    /// </summary>
    public string? GetFixedWidth() => $"{(!_fixedWidth!.Equals(nameof(FixedWidth)) && _fixedWidth.ToLower().Equals("true") ? FontAwesome.Size.FixedWidth : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for Icon1.
    /// </summary>
    public string? GetIcon1() => $"{(!_icon1!.Equals(nameof(Icon1)) ? _icon1 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for Icon2.
    /// </summary>
    public string? GetIcon2() => $"{(!_icon2!.Equals(nameof(Icon2)) ? _icon2 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconColor1.
    /// </summary>
    public string? GetIconColor1() => $"{(!_iconColor1!.Equals(nameof(IconColor1)) ? _iconColor1 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconColor2.
    /// </summary>
    public string? GetIconColor2() => $"{(!_iconColor2!.Equals(nameof(IconColor2)) ? _iconColor2 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconCss1.
    /// </summary>
    public string? GetIconCss1() => $"{(!_iconCss1!.Equals(nameof(IconCss2)) ? _iconCss1 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconCss2.
    /// </summary>
    public string? GetIconCss2() => $"{(!_iconCss2!.Equals(nameof(IconCss2)) ? _iconCss2 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconSize1.
    /// </summary>
    public string? GetIconSize1() => $"{(!_iconSize1!.Equals(nameof(IconSize1)) ? _iconSize1 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconSize2.
    /// </summary>
    public string? GetIconSize2() => $"{(!_iconSize2!.Equals(nameof(IconSize2)) ? _iconSize2 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconStackSize1.
    /// </summary>
    public string? GetIconStackSize1() => $"{(!_iconStackSize1!.Equals(nameof(IconStackSize2)) ? _iconStackSize1 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconStackSize2.
    /// </summary>
    public string? GetIconStackSize2() => $"{(!_iconStackSize2!.Equals(nameof(IconStackSize2)) ? _iconStackSize2 : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for IconStyle.
    /// </summary>
    public string? GetIconStyle1() => $"{(!_iconStyle1!.Equals(nameof(IconStyle1)) ? _iconStyle1 : "fas")}";

    /// <summary>
    /// Gets the UI display string for IconStyle2.
    /// </summary>
    public string? GetIconStyle2() => $"{(!_iconStyle2!.Equals(nameof(IconStyle2)) ? _iconStyle2 : "fas")}";

    /// <summary>
    /// Gets the UI display string for Name.
    /// </summary>
    public string? GetName() => _name;

    /// <summary>
    /// Gets the UI display string for Stacked.
    /// </summary>
    public string? GetStacked() => $"{(!_stacked!.Equals(nameof(Stacked)) && _stacked!.ToLower().Equals("true") ? FontAwesome.Size.FixedWidth : string.Empty)}";

    /// <summary>
    /// Gets the UI display string for StackSize.
    /// </summary>
    public string? GetStackSize() => $"{(!_stackSize!.Equals(nameof(StackSize)) ? _stackSize : string.Empty)}";

#endregion Methods
  }
}