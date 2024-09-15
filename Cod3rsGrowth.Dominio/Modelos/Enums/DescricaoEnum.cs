using System.ComponentModel;
using System.Reflection;

public static class DescricaoEnum
{
    public static Dictionary<int, string> ObterDescricaoEnum<T>() where T : Enum
    {
        var tipoEnum = typeof(T);
        var chaveEnum = Enum.GetValues(tipoEnum).Cast<T>();
        var descricaoEnum = new Dictionary<int, string>();

        foreach (var chave in chaveEnum)
        {
            var propriedadesEnum = tipoEnum.GetField(chave.ToString());
            var descricaoDoEnum = (DescriptionAttribute)propriedadesEnum.GetCustomAttribute(typeof(DescriptionAttribute));
            var descricaoTexto = descricaoDoEnum == null ? chave.ToString() : descricaoDoEnum.Description;
            descricaoEnum.Add(Convert.ToInt32(chave), descricaoTexto);
        }

        return descricaoEnum;
    }
}
