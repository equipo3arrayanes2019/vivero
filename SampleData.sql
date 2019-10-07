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
INSERT INTO `Sensor`(`id`, `tipo`, `Zona_nombre`) VALUES
					-- ----------- zone 1, 4 sensors
					("ARD01 HUMIDITYAIR01", "HUMIDITYAIR", "Invernáculo 01"),
                    ("ARD01 HUMIDITYSOIL01", "HUMIDITYSOIL", "Invernáculo 01"),
                    ("ARD01 TEMPERATUREAIR01", "TEMPERATUREAIR", "Invernáculo 01"),
                    ("ARD01 TEMPERATURE01", "TEMPERATURESOIL", "Invernáculo 01"),
                    -- ----------- zone 2, 4 sensors
                    ("ARD02 HUMIDITYAIR01", "HUMIDITYAIR", "Invernáculo 02"),
                    ("ARD02 HUMIDITYSOIL01", "HUMIDITYSOIL", "Invernáculo 02"),
                    ("ARD02 TEMPERATUREAIR01", "TEMPERATUREAIR", "Invernáculo 02"),
                    ("ARD02 TEMPERATURE01", "TEMPERATURESOIL", "Invernáculo 02"),
                    -- ----------- zone 3, 4 sensors
                    ("ARD03 HUMIDITYAIR01", "HUMIDITYAIR", "Sombráculo 02"),
                    ("ARD03 HUMIDITYSOIL01", "HUMIDITYSOIL", "Sombráculo 02"),
                    ("ARD03 TEMPERATUREAIR01", "TEMPERATUREAIR", "Sombráculo 02"),
                    ("ARD03 TEMPERATURE01", "TEMPERATURESOIL", "Sombráculo 02"),
                    -- ----------- zone 4, 4 sensors
                    ("ARD04 HUMIDITYAIR01", "HUMIDITYAIR", "Aire libre 07"),
                    ("ARD04 HUMIDITYSOIL01", "HUMIDITYSOIL", "Aire libre 07"),
                    ("ARD04 TEMPERATUREAIR01", "TEMPERATUREAIR", "Aire libre 07"),
                    ("ARD04 TEMPERATURE01", "TEMPERATURESOIL", "Aire libre 07");

--  MEASUREMENT DATA -----------------------------------------------------------------
DELETE FROM `Medicion` WHERE TRUE;
INSERT INTO `Medicion`(`fecha`, `valor`, `Zona_Nombre`, `Sensor_id`) VALUES
					-- Greenhouse 01 HIMIDITY AIR
					("2019-10-09 10:20-00", "40", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:30-00", "42", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:40-00", "43", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:50-00", "48", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 10:00-00", "41", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:10-00", "39", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:20-00", "38", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:30-00", "60", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:40-00", "50", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    ("2019-10-09 11:50-00", "40", "Invernáculo 01", "ARD01 HUMIDITYAIR01"),
                    -- Greenhouse 01 HIMIDITY SOIL
                    ("2019-10-09 10:20-00", "10", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:30-00", "9", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:40-00", "14", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:50-00", "16", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 10:00-00", "13", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:10-00", "12", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:20-00", "9", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:30-00", "25", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:40-00", "23", "Invernáculo 01", "ARD01 HUMIDITYSOIL01"),
                    ("2019-10-09 11:50-00", "15", "Invernáculo 01", "ARD01 HUMIDITYSOIL01");
-- some species
DELETE FROM `Especie`;
INSERT INTO `Especie`(`nombre`, `tipo`, `familia`, `tipoZona`, `tiempoCultivo`, `tipoLuna`, `humedad`) VALUES
					("(Cilantro) Coriandrum Sativum", "Aromática", "Apiaceae", "Invernáculo", 60, "Menguante", 20.0),
                    ("(Menta) Mentha Spicata", "Aromática", "Labiatae", "Invernáculo", 90, "Menguante", 45.0);
-- some plants
DELETE FROM `Planta`;
INSERT INTO `Planta`(`precio`, `Zona_nombre`, `Especie_nombre`) VALUES
					(220.5, "Invernáculo 01", "(Cilantro) Coriandrum Sativum");

-- some seeds
DELETE FROM `Semilla`;
INSERT INTO `Semilla`(`fecha`, `cantidad`, `Especie_nombre`) VALUES
					("2019-08-05 12:33:00", 3, "(Menta) Mentha Spicata");

DELETE FROM `Zona_has_Semilla`;
INSERT INTO `Zona_has_Semilla`(`Zona_nombre`, `Semilla_id`) VALUES
					("Invernáculo 01", LAST_INSERT_ID());

SET FOREIGN_KEY_CHECKS=1;
