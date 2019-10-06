USE MeGusta;
SET FOREIGN_KEY_CHECKS=0;
-- locations data
-- ----------- Zones --------------------------------------------
DELETE FROM `Zona` WHERE TRUE;
INSERT INTO `Zona`(`nombre`, `tamaño`, `tipo`) VALUES
				("Invernáculo 01", "2x2", "Invernáculo"),
                ("Invernáculo 02", "2x2", "Invernáculo"),
                ("Sombráculo 02", "3x2", "Sombráculo" ),
                ("Aire libre 07", "8x8", "Aire Libre" );

-- Sensor data
-- ----------- sensors ------------------------------------------
DELETE FROM `Sensor` WHERE TRUE;
INSERT INTO `Sensor`(`id`, `tipo`, `Zona_Nombre`) VALUES
					-- ----------- zone 1, 4 sensors
					("ARD01 HUMIDITYAIR01", "HUMIDITY", "Invernáculo 01"),
                    ("ARD01 HUMIDITYSOIL01", "HUMIDITY", "Invernáculo 01"),
                    ("ARD01 TEMPERATUREAIR01", "TEMPERATURE", "Invernáculo 01"),
                    ("ARD01 TEMPERATURE01", "TEMPERATURE", "Invernáculo 01"),
                    -- ----------- zone 2, 4 sensors
                    ("ARD02 HUMIDITYAIR01", "HUMIDITY", "Invernáculo 02"),
                    ("ARD02 HUMIDITYSOIL01", "HUMIDITY", "Invernáculo 02"),
                    ("ARD02 TEMPERATUREAIR01", "TEMPERATURE", "Invernáculo 02"),
                    ("ARD02 TEMPERATURE01", "TEMPERATURE", "Invernáculo 02"),
                    -- ----------- zone 3, 4 sensors
                    ("ARD03 HUMIDITYAIR01", "HUMIDITY", "Sombráculo 02"),
                    ("ARD03 HUMIDITYSOIL01", "HUMIDITY", "Sombráculo 02"),
                    ("ARD03 TEMPERATUREAIR01", "TEMPERATURE", "Sombráculo 02"),
                    ("ARD03 TEMPERATURE01", "TEMPERATURE", "Sombráculo 02"),
                    -- ----------- zone 4, 4 sensors
                    ("ARD04 HUMIDITYAIR01", "HUMIDITY", "Aire libre 07"),
                    ("ARD04 HUMIDITYSOIL01", "HUMIDITY", "Aire libre 07"),
                    ("ARD04 TEMPERATUREAIR01", "TEMPERATURE", "Aire libre 07"),
                    ("ARD04 TEMPERATURE01", "TEMPERATURE", "Aire libre 07");

--  MEASUREMENT DATA -----------------------------------------------------------------
DELETE FROM `Medicion` WHERE TRUE;
INSERT INTO `Medicion`(`fecha`, `valor`, `tipo`, `Zona_Nombre`, `Sensor_id`) VALUES
					-- Invernáculo 01 HIMIDITY AIR
					("2019-10-09 10:20-00", "40", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:30-00", "42", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:40-00", "43", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:50-00", "48", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:00-00", "41", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:10-00", "39", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:20-00", "38", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:30-00", "60", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:40-00", "50", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:50-00", "40", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    -- Invernáculo 01 HIMIDITY SOIL
                    ("2019-10-09 10:20-00", "10", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:30-00", "9", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:40-00", "14", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:50-00", "16", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:00-00", "13", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:10-00", "12", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:20-00", "9", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:30-00", "25", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:40-00", "23", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:50-00", "15", "HUMIDITY", "Invernáculo 01", "ARD01 HUMIDITYSOIL01");
SET FOREIGN_KEY_CHECKS=1;
