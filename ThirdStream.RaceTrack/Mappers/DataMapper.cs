using System;
using System.Collections.Generic;
using ThirdStream.RaceTrack.Models;
using Entities =ThirdStream.RaceTrack.Data.Entities;

namespace ThirdStream.RaceTrack.Mappers
{
    /// <summary>
    /// Class DataMapper.
    /// </summary>
    public static class DataMapper
    {
        /// <summary>
        /// Maps to dto.
        /// </summary>
        /// <param name="track">The track.</param>
        /// <returns>Track.</returns>
        public static Track MapToDto(this Entities.Track track)
        {
            var result = new Track
            {
                Id = track.Id,
                Name = track.Name,
                TrackType = track.Type,
                Vehicles = new List<BaseVehicle>()
            };

            foreach (var vehicle in track.Vehicles)
            {
                result.Vehicles.Add(vehicle.MapToDto());
            }

            return result;
        }

        /// <summary>
        /// Maps to dto.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns>BaseVehicle.</returns>
        /// <exception cref="Exception">Invalid data: unknown vehicle type!</exception>
        public static BaseVehicle MapToDto(this Entities.Vehicle vehicle)
        {
            if (vehicle.Type == "Car")
            {
                return new Car
                {
                    Id = vehicle.Id,
                    HasTowStrap = vehicle.HasTowStrap,
                    TireWearPercentage = vehicle.TireWearPercentage,
                    TrackId = vehicle.TrackId
                };
            }

            if (vehicle.Type == "Truck")
            {
                return new Truck
                {
                    Id = vehicle.Id,
                    HasTowStrap = vehicle.HasTowStrap,
                    Lift = vehicle.Lift,
                    TrackId = vehicle.TrackId
                };
            }

            throw new Exception("Invalid data: unknown vehicle type!");
        }

        /// <summary>
        /// Maps to entity.
        /// </summary>
        /// <param name="car">The car.</param>
        /// <returns>Entities.Vehicle.</returns>
        public static Entities.Vehicle MapToEntity(this Car car)
        {
            return new Entities.Vehicle()
            {
                HasTowStrap = car.HasTowStrap,
                TireWearPercentage = car.TireWearPercentage,
                TrackId = car.TrackId,
                Type = "Car"
            };
        }

        /// <summary>
        /// Maps to entity.
        /// </summary>
        /// <param name="truck">The truck.</param>
        /// <returns>Entities.Vehicle.</returns>
        public static Entities.Vehicle MapToEntity(this Truck truck)
        {
            return new Entities.Vehicle()
            {
                HasTowStrap = truck.HasTowStrap,
                Lift = truck.Lift,
                TrackId = truck.TrackId,
                Type = "Truck"
            };
        }

        /// <summary>
        /// Maps to entity.
        /// </summary>
        /// <param name="track">The track.</param>
        /// <returns>Entities.Track.</returns>
        public static Entities.Track MapToEntity(this Track track)
        {
            return new Entities.Track()
            {
                Name = track.Name,
                Type = track.TrackType
            };
        }
    }
}