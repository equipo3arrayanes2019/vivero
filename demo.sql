USE MeGusta;
SET FOREIGN_KEY_CHECKS=0;
-- locations data
-- ----------- Zones --------------------------------------------
DELETE FROM `Zona` WHERE TRUE;
INSERT INTO `Zona`(`nombre`, `tamaño`, `tipo`) VALUES
				("Invernáculo", "2x2", "Invernáculo"),
                ("Sombráculo", "3x2", "Sombráculo" ),
                ("Aire libre", "8x8", "Aire Libre" );
                
DELETE FROM `Sensor` WHERE TRUE;
INSERT INTO `Sensor`(`id`, `tipo`, `Zona_nombre`) VALUES
					-- ----------- zone 1, 4 sensors
					("ARD01 HUMIDITYAIR01", "HUMIDITYAIR", "Invernáculo"),
                    ("ARD01 HUMIDITYSOIL01", "HUMIDITYSOIL", "Invernáculo"),
                    ("ARD01 TEMPERATUREAIR01", "TEMPERATUREAIR", "Invernáculo"),
                    ("ARD01 TEMPERATURESOIL01", "TEMPERATURESOIL", "Invernáculo"),
                    -- ----------- zone 2, 4 sensors
                    ("ARD01 HUMIDITYAIR02", "HUMIDITYAIR", "Sombráculo"),
                    ("ARD01 HUMIDITYSOIL02", "HUMIDITYSOIL", "Sombráculo"),
                    ("ARD01 TEMPERATUREAIR02", "TEMPERATUREAIR", "Sombráculo"),
                    ("ARD01 TEMPERATURESOIL02", "TEMPERATURESOIL", "Sombráculo"),
                    -- ----------- zone 3, 4 sensors
                    ("ARD01 HUMIDITYAIR03", "HUMIDITYAIR", "Aire libre"),
                    ("ARD01 HUMIDITYSOIL03", "HUMIDITYSOIL", "Aire libre"),
                    ("ARD01 TEMPERATUREAIR03", "TEMPERATUREAIR", "Aire libre"),
                    ("ARD01 TEMPERATURESOIL03", "TEMPERATURESOIL", "Aire libre");

DELETE FROM `Especie`;
INSERT INTO `Especie`(`nombre`, `tipo`, `familia`, `tipoZona`, `tiempoCultivo`, `tipoLuna`, `humedad`) VALUES
					("(Cilantro) Coriandrum Sativum", "Aromática", "Apiaceae", "Invernáculo", 60, "Menguante", 20.0),
                    ("(Menta) Mentha Spicata", "Aromática", "Labiatae", "Invernáculo", 90, "Menguante", 45.0);
-- some plants
DELETE FROM `Planta`;
INSERT INTO `Planta`(`precio`, `Zona_nombre`, `Especie_nombre`, `Plantacion_id`, `Plantacion_Semilla_id`, `Plantacion_Maceta_id`, `Maceta_id` ) VALUES
					(220.5, "Aire libre", "(Cilantro) Coriandrum Sativum", 1, 1, 1, 1),
                    (220.5, "Sombráculo", "(Menta) Mentha Spicata", 1, 1, 1, 1),
                    (220.5, "Invernáculo", "(Cilantro) Coriandrum Sativum", 1, 1, 1, 1)
                    ;
SET FOREIGN_KEY_CHECKS=1;