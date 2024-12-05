using System;

namespace BankAccountAndBuilding
{
    public class Building
    {
        private static int lastBuildingNumber = 1;
        private int buildingNumber;
        private float height; // В метрах
        private int floors;
        private int apartments;
        private int entrances;

        public Building()
        {
            buildingNumber = lastBuildingNumber++;
        }

        public void SetHeight(float height) => this.height = height;
        public void SetFloors(int floors) => this.floors = floors;
        public void SetApartments(int apartments) => this.apartments = apartments;
        public void SetEntrances(int entrances) => this.entrances = entrances;

        public float FloorHeight() => height / floors;
        public int ApartmentsPerFloor() => apartments / floors;
        public int ApartmentsPerEntrance() => apartments / entrances;

        public void DisplayInfo()
        {
            Console.WriteLine($"Уникальный номер здания: {buildingNumber}, Высота: {height} м, Этажность: {floors}, Количество квартир: {apartments}, Количество подъездов: {entrances}");
        }
    }
}