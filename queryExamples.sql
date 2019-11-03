-- sensor location
-- SELECT `Zona_Nombre` FROM `Sensor` WHERE id='';
-- location plants
SELECT `Especie`.`Nombre`, `Especie`.`humedad` FROM `Zona`
		INNER JOIN `Planta` ON `Zona`.`nombre` = `Planta`.`Zona_nombre`
        INNER JOIN `Zona_has_Semilla` ON `Zona_has_Semilla`.`Zona_nombre` = `Zona`.`nombre`
        INNER JOIN `Semilla` ON `Zona_has_Semilla`.`Semilla_id` = `Semilla`.`id`
        INNER JOIN `Especie` ON `Semilla`.`Especie_nombre` = `Especie`.`nombre` OR `Planta`.`Especie_nombre` = `Especie`.`nombre`
        WHERE `Zona`.`nombre`= "Invernáculo 01";

-- SELECT `Especie`.`Nombre`, `Especie`.`humedad` FROM `Zona` INNER JOIN `Planta` ON `Zona`.`nombre` = `Planta`.`Zona_nombre` INNER JOIN `Zona_has_Semilla` ON `Zona_has_Semilla`.`Zona_nombre` = `Zona`.`nombre` INNER JOIN `Semilla` ON `Zona_has_Semilla`.`Semilla_id` = `Semilla`.`id` INNER JOIN `Especie` ON `Semilla`.`Especie_nombre` = `Especie`.`nombre` OR `Planta`.`Especie_nombre` = `Especie`.`nombre` WHERE `Zona`.`nombre`= "Invernáculo 01";