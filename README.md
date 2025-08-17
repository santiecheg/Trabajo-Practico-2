Trabajo Práctico 2 (Primer año, Tecnicatura en Desarrollo de Software Encode)

Introducción 

Se solicita desarrollar en C# un sistema que simule vueltas de clasificación en una carrera. Cada vuelta está compuesta por tres sectores (S1, S2 y S3), en los que el piloto registra un tiempo parcial. A cada sector se le pueden aplicar penalizaciones que aumentan su tiempo.

Requisitos del Sistema
El programa debe mostrar un mensaje de bienvenida y a continuación informar las opciones disponibles: 
-Simular vueltas
-Mostrar Reporte
-Iniciar Sesión
-Cerrar Sesión
-Registrar Usuario
-Salir

1) Simular Vueltas: El sistema deberá solicitar al usuario la cantidad de intentos de vuelta que intenta simular. Por cada intento: 
Generar tiempos para cada sector ( entre 20 y 40 segundos)
Generar penalizaciones. En F1 se penaliza con pérdida de tiempo, típicamente entre 0.1 y 5 segundos según la gravedad.
Sumar tiempo total de vuelta
Mostrar si fue la mejor vuelta hasta el momento 
2) Mostrar Reporte: 
Tiempo promedio de cada sector. 
Tiempo promedio total de vuelta. 
Cantidad de penalizaciones aplicadas y tiempo promedio de penalización. 
Mejor vuelta registrada (tiempo total más bajo)
Si aún no se simuló ninguna vuelta, el sistema deberá mostrar un mensaje informando que no hay datos disponibles para calcular el reporte.

3) Iniciar sesión: ingresar dni y contraseña. Permitir hasta 3 intentos. Nota: dado que no se permite el uso de listas, el sistema puede registrar y mantener una única sesión activa por ejecución.
4) Cerrar Sesión: se borran los datos de sesión. 
5) Registrar Usuario: se le solicita al usuario su dni y contraseña. La contraseña debe contener al menos 3 números, una mayúscula, una minúscula y 8 caracteres en total. Se debe verificar que el dni tenga la cantidad de caracteres correcta. 
6) Salir: salir del ciclo, no se vuelve a mostrar el menú de opciones.  

Aclaraciones
Leer atentamente todo el trabajo práctico antes de comenzar a programar.
Utilicen estructuras condicionales y repetitivas para manejar las diferentes opciones y cálculos del programa.
No deben crearse listas, clases ni arreglos.
Añadan comentarios en el código para explicar la lógica detrás de alguna sección importante si lo consideran necesario. 
Procuren que el programa sea interactivo y fácil de entender para el usuario.
Se les solicita implementar al menos dos funciones.
El sistema no debería permitir simular vueltas ni ver reportes si no hay un usuario logueado. 
Para poder realizar la entrega del trabajo deben estar registrados en un grupo. Se solicita registrarlo con anticipación. 
