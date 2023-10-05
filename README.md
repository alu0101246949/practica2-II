# Informe de Práctica: Interfaces Inteligentes
### Estudiante: Laura Ramallo Pérez
### Asignatura: Interfaces Inteligentes

## Objetivo de la Práctica
El objetivo principal de esta práctica es profundizar en el conocimiento de Unity y en la programación de scripts para crear interacciones y manipulaciones de objetos dentro de una escena.

## Desarrollo de la Práctica

### Ejercicio 1: Manipulación de Array con Valores Aleatorios
Desarrollé un script en C# asociado a un cubo en Unity. Este script inicializa un array con valores aleatorios entre 0 y 25. A cada frame, una posición aleatoria del array es modificada y aquellos valores mayores a 15 son mostrados en la consola de Unity. Adicionalmente, parametricé el rango de valores aleatorios para facilitar modificaciones desde el inspector de Unity.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/6d9ebeba-0de9-4d1d-9c82-e184527e82fe)

### Ejercicio 2: Creación de una Escena con Diferentes Objetos y Materiales
Construí una escena básica compuesta por un plano, un cubo, una esfera y un cilindro. Asigné a cada objeto un color diferente creando y utilizando materiales, los cuales fueron almacenados en una carpeta denominada “Materials” dentro de los Assets de Unity. Además, a través de un script, cada objeto muestra su nombre en la consola al inicio de la escena.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/3889010d-ed27-412c-999f-764044c53209)
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/5d68504d-e949-47cd-a7f7-d46715d9b5bd)

### Ejercicio 3: Trabajo con Vectores en Unity
Elaboré un script asociado a la esfera, donde definí dos vectores `Vector3` públicos. Realicé operaciones con estos vectores para mostrar en la consola y en el inspector su magnitud, el ángulo entre ellos, la distancia que los separa y un mensaje indicando cuál está a una altura mayor.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/b6736583-1679-422a-962d-9f5193fadca6)
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/1b6a4f01-59a6-4eb2-933a-8253ee4723c6)

### Ejercicio 4: Mostrar la Posición de la Esfera
Mediante un script, logré mostrar la posición del objeto esfera en la consola, utilizando tanto la propiedad `transform.position` como la función `GetComponent<Transform>()`.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/c3553ab9-86fc-412d-bfbf-dca00e081bf8)

### Ejercicio 5: Cálculo de Distancias entre Objetos
Implementé un script que calcula y muestra en la consola la distancia entre la esfera y los otros dos objetos (cubo y cilindro).
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/d6f78e91-716a-4237-b56f-af20bde8ca64)
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/9ae9bd8d-83ca-457b-ac0b-2408df73972f)

### Ejercicio 6: Alineación de Objetos en un Eje Específico
Desarrollé un script que alinea automáticamente el cilindro y el cubo con la esfera, situándolos a 5 unidades a la derecha e izquierda respectivamente en el eje X.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/c24429f6-0e38-4649-b37d-1c6a0c54bcd2)
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/1da2747f-2d3f-497b-98eb-fc4c1c773d04)

### Ejercicio 7: Cambio de Color mediante Input del Usuario
Implementé la lógica para cambiar el color del cilindro y del cubo al presionar las teclas "A" y la flecha arriba respectivamente, utilizando la clase `Input` de Unity.
![image](https://github.com/alu0101246949/practica2-II/assets/114754476/b4fdd6ab-fe5a-46b6-aa86-25e6e1531cb2)

### Ejercicio 8: Manipulación de Grupos de Objetos y Distancias
Agregué 5 esferas a la escena, agrupándolas mediante etiquetas. Creé un vector con las distancias de un grupo de esferas respecto al cubo y, mediante un script, aumenté la altura de la esfera más cercana al cubo y cambié el color de la más lejana al pulsar la tecla espacio.

## Conclusión
Esta práctica ha sido esencial para familiarizarme más con el entorno de Unity y la lógica de programación en C# para desarrollar interacciones en escenas 3D. A través de los diferentes ejercicios, pude explorar y aprender acerca de la manipulación de objetos, vectores, materiales, y la captura de inputs del usuario en Unity.

---

Laura Ramallo Pérez
