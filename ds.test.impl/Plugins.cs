using System.Collections.Generic;

namespace ds.test.impl
{
    /// <summary>
    /// Класс, реализующий хранилище плагинов.
    /// </summary>
    public class Plugins : PluginFactory
    {
        private List<IPlugin> _plugins = new List<IPlugin> { new AddNumbers(), new MultiplyNumbers() };
        // В связи с технической невозможностью использовать статические классы для реализации интерфейсов был использован следующий подход (singleton)
        private static Plugins _instance;
        /// <summary>
        /// Экземпляр класса для использования.
        /// </summary>
        public static Plugins GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Plugins();
            }
            return _instance;
        }
        /// <summary>
        /// Получает доступное количество плагинов в библиотеке.
        /// </summary>
        /// <returns>Доступное количество плагинов в библиотеке.</returns>
        public int PluginsCount { get => _plugins.Count; }
        /// <summary>
        /// Получает имена доступных плагинов в библиотеке.
        /// </summary>
        /// <returns>Имена доступных плагинов в библиотеке.</returns>
        public string[] GetPluginNames
        {
            get
            {
                string[] result = new string[_plugins.Count];
                for (int i = 0; i < _plugins.Count; i++)
                {
                    result[i] = _plugins[i].PluginName;
                }
                return result;
            }
        }
        /// <summary>
        /// Получает экземпляр плагина по заданному именем.
        /// </summary>
        /// <returns>Имена доступных плагинов в библиотеке.</returns>
        /// <exception cref="KeyNotFoundException">Плагин с указанным именем не найден...</exception>
        public IPlugin GetPlugin(string pluginName)
        {
            for (int i = 0; i < _plugins.Count; i++)
            {
                if (_plugins[i].PluginName.Equals(pluginName))
                {
                    return _plugins[i];
                }
            }
            throw new KeyNotFoundException();
        }
    }
}
