public T ParseOrNull<T>(string value)
{
    if (value.ToLower() == "null")
    {
        return default(T);
    }

    try
    {
        var type = typeof(T);
        type = Nullable.GetUnderlyingType(type) ?? type;

        return (T)Convert.ChangeType(value, type);
    }
    catch
    {
        return default(T);
    }
}
