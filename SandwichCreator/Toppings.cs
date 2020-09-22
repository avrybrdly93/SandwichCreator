using SandwichCreator.Resources;
using System.ComponentModel;

namespace SandwichCreator
{
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum BreadType
    {
        [Description("White")]
        White,
        [Description("Wheat")]
        Wheat,
        [Description("Sourdough")]
        Sourdough
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum MeatType
    {
        [Description("Chicken")]
        Chicken,
        [Description("Turkey")]
        Turkey,
        [Description("Ham")]
        Ham
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CheeseType
    {
        [Description("Provolone")]
        Provolone,
        [Description("Swiss")]
        Swiss,
        [Description("Cheddar")]
        Cheddar
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum CondimentType
    {
        [Description("Mustard")]
        Mustard,
        [Description("Mayonaise")]
        Mayonaise
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum VeggiesType
    {
        [Description("Tomatoes")]
        Provolone,
        [Description("Lettuce")]
        Swiss,
        [Description("Pickles")]
        Pickles,
        [Description("Onion")]
        Cheddar
    }
    [TypeConverter(typeof(EnumDescriptionTypeConverter))]
    public enum SpicesType
    {
        [Description("Salt + Pepper")]
        SaltPepper,
        [Description("Oregano")]
        Swiss,
        [Description("Sweet Basil")]
        Cheddar,
        [Description("Rosemary")]
        Rosemary
    }
}
