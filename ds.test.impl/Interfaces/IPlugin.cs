namespace ds.test.impl
{
    /// <summary>
    /// Интерфейс для реализации плагинов в библиотеке.
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Имя плагина.
        /// </summary>
        string PluginName { get; }
        /// <summary>
        /// Версия плагина.
        /// </summary>
        string GetVersion();
        /// <summary>
        /// Изображение (иконка) плагина.
        /// </summary>
        System.Drawing.Image Image { get; }
        /// <summary>
        /// Описание плагина.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Функция, выполняющая код плагина.
        /// </summary>
        /// <param name="input1">Первое число.</param>
        /// <param name="input2">Второе число.</param>
        int Run(int input1, int input2);
    }
}
