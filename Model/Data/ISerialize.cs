using Model.Core.DishClasses;
using Model.Core.RestaurantClasses;
using System.Collections.Generic;

namespace Model.Data
{
    public interface ISerialize
    {
        void Serialize<T>(T obj, string filePath) where T : Restaurant;
        List<T> DeserializeAllFiles<T>(string filename, string expansion) where T : Restaurant;
        DishDTO DishSerializer<T>(T d) where T : class;
        Dish DeserializeDish<T>(T dto) where T : class;
        T DeserializeRestaurant<T>(string fileName) where T : Restaurant;
    }
} 