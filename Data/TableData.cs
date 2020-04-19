using DashboardService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DashboardService.Data
{
    public class TableData : IChartData
    {
        public IChartModel[] Data { get; set; }

        public TableData() => Data = new TableModel[]
            {
                new TableModel(){
                    Position= 1,
                    Name= "Hydrogen",
                    Weight= 1.0079,
                    Symbol= "H"
                },
                new TableModel(){
                    Position= 2,
                    Name= "Helium",
                    Weight= 4.0026,
                    Symbol= "He"
                },
                new TableModel(){
                    Position= 3,
                    Name= "Lithium",
                    Weight= 6.941,
                    Symbol= "Li"
                },
                new TableModel(){
                    Position= 4,
                    Name= "Beryllium",
                    Weight= 9.0122,
                    Symbol= "Be"
                },
                new TableModel(){
                    Position= 5,
                    Name= "Boron",
                    Weight= 10.811,
                    Symbol= "B"
                },
                new TableModel(){
                    Position= 6,
                    Name= "Carbon",
                    Weight= 12.0107,
                    Symbol= "C"
                },
                new TableModel(){
                    Position= 7,
                    Name= "Nitrogen",
                    Weight= 14.0067,
                    Symbol= "N"
                },
                new TableModel(){
                    Position= 8,
                    Name= "Oxygen",
                    Weight= 15.9994,
                    Symbol= "O"
                },
                new TableModel(){
                    Position= 9,
                    Name= "Fluorine",
                    Weight= 18.9984,
                    Symbol= "F"
                },
                new TableModel(){
                    Position= 10,
                    Name= "Neon",
                    Weight= 20.1797,
                    Symbol= "Ne"
                },
                new TableModel(){
                    Position= 11,
                    Name= "Sodium",
                    Weight= 22.9897,
                    Symbol= "Na"
                },
                new TableModel(){
                    Position= 12,
                    Name= "Magnesium",
                    Weight= 24.305,
                    Symbol= "Mg"
                },
                new TableModel(){
                    Position= 13,
                    Name= "Aluminum",
                    Weight= 26.9815,
                    Symbol= "Al"
                },
                new TableModel(){
                    Position= 14,
                    Name= "Silicon",
                    Weight= 28.0855,
                    Symbol= "Si"
                },
                new TableModel(){
                    Position= 15,
                    Name= "Phosphorus",
                    Weight= 30.9738,
                    Symbol= "P"
                },
                new TableModel(){
                    Position= 16,
                    Name= "Sulfur",
                    Weight= 32.065,
                    Symbol= "S"
                },
                new TableModel(){
                    Position= 17,
                    Name= "Chlorine",
                    Weight= 35.453,
                    Symbol= "Cl"
                },
                new TableModel(){
                    Position= 18,
                    Name= "Argon",
                    Weight= 39.948,
                    Symbol= "Ar"
                },
                new TableModel(){
                    Position= 19,
                    Name= "Potassium",
                    Weight= 39.0983,
                    Symbol= "K"
                },
                new TableModel(){
                    Position= 20,
                    Name= "Calcium",
                    Weight= 40.078,
                    Symbol= "Ca"
                }
            };
    }
}
