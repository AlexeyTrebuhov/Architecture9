using System.Reflection.Metadata.Ecma335;

namespace MyFirstWebApplication.Models
{
    public class WeatherForecastModel
    {
        // Коллекция для хранения показаний температуры
        private List<WeatherForecast> _list;


        public WeatherForecastModel()
        {
            _list = new List<WeatherForecast>();
        }

        public void Add(DateTime date, int temperatureC)
        {
            WeatherForecast weatherForecast = new WeatherForecast(date, temperatureC);
            _list.Add(weatherForecast);
        }

        public void Update(DateTime date, int temperatureC)
        {
            foreach (WeatherForecast weatherForecast in _list)
            {
                if (weatherForecast.Date == date)
                {
                    weatherForecast.TemperatureC = temperatureC;
                    break;
                }
            }
        }

        
        public List<WeatherForecast> GetAll(DateTime dateFrom, DateTime dateTo)
        {
            List<WeatherForecast> listByDate = new List<WeatherForecast>();

            foreach (WeatherForecast weatherForecast in _list)
            {
                if (weatherForecast.Date >= dateFrom && weatherForecast.Date <= dateTo)
                {
                    listByDate.Add(weatherForecast);

                }
            }
            return listByDate;

        }


        //TODO: ДОМАШНЯЯ РАБОТА
        // Доработать метод Delete на уровне модели данных и контроллера.


        public void Delete (DateTime date)
       
        {
            int itemToRemove = -1;
            foreach (WeatherForecast weatherForecast in _list)
            {
                itemToRemove = itemToRemove + 1;
                if (weatherForecast.Date! == date)
                {
                   _list.RemoveAt(itemToRemove);
                    break;
                }  
            }
        }
    }
}
