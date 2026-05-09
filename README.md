#  Catálogo de Videojuegos 

Un catálogo interactivo de videojuegos desarrollado en **ASP.NET Core**, diseñado con una estética oscura y gótica inspirada en el mundo gamer. El proyecto destaca por su interfaz fluida, efectos visuales dinámicos y un diseño basado en la experiencia de usuario.

##  Descripción del Proyecto
Esta aplicación permite gestionar y visualizar un catálogo de videojuegos clasificados por géneros. El objetivo fue transformar una interfaz estándar en una plataforma profesional con identidad visual propia, utilizando técnicas avanzadas de CSS y JavaScript para mejorar la inactividad.

### Características Clave:
* **Interfaz Glassmorphism**: Uso de fondos semi-trasparentes con desenfoque para dar profundidad.
* **Fondo Dinámico**: Efecto de lluvia constante animado mediante CSS.
* **Navegación Fluida**: Sistema de transiciones suaves (Fade/Slide) entre las vistas de catálogo y detalles.
* **Diseño Responsivo**: Adaptabilidad completa para dispositivos móviles y escritorio.
* **Filtros de Categoría**: Clasificación rápida de títulos por géneros como Metroidvania, Shooter y Action RPG.

##  Tecnologías Usadas
* **Frontend**: 
    * HTML5 y CSS3 avanzado.
    * Bootstrap 5 para la estructura de rejilla (Grid System).
    * JavaScript Vanilla para lógica de transiciones y efectos.
* **Fuentes**: Google Fonts (Creepster) para el estilo temático.

##  Capturas de Pantalla
menu de inicio de la aplicacion 
<img width="1920" height="1080" alt="Captura de pantalla (25)" src="https://github.com/user-attachments/assets/2f1455ca-73ed-4451-95b6-a20f4d9ff628" />
agregar un juego 
<img width="1920" height="1080" alt="Captura de pantalla (26)" src="https://github.com/user-attachments/assets/fe0c75a7-530c-4375-b3da-08bbdb5b4108" />
confimacion del juego 
<img width="1920" height="1080" alt="Captura de pantalla (27)" src="https://github.com/user-attachments/assets/935fbf6f-609a-4791-8c20-b6dcf8661b0e" />
informacion del juego 
<img width="1920" height="1080" alt="Captura de pantalla (28)" src="https://github.com/user-attachments/assets/8f0bbd8d-27bf-49cb-ad30-702c7f86ff05" />

Declaracion de IA:

Nombre del estudiante: Rodrigo Rios

IA utilizada: Gemini

Fecha de uso: 2026-05-08

Propósito: Problemas con github

Prompt utilizado:

le estoy dando a que haga comits pero no se ve reflejado en github 
Respuesta en crudo (raw):

Es frustrante cuando trabajas duro en el código, haces el commit y la barrita de contribuciones en GitHub sigue vacía. Lo más probable es que los cambios se hayan quedado "atrapados" en tu computadora.

Aquí te explico por qué pasa esto y cómo solucionarlo en Visual Studio:

1. El Commit no es lo mismo que el Push
En Git, hacer un Commit solo guarda los cambios en tu base de datos local (en tu PC). Para que aparezcan en GitHub, debes hacer un Push.

La solución: En Visual Studio, busca el icono de las flechas (una hacia arriba y otra hacia abajo) en la barra de estado inferior, o ve a la pestaña "Cambios de Git" y haz clic en la flecha que apunta hacia arriba (Insertar/Push).

2. Configuración del Correo (El "Fantasma" de los Commits)
Si ya hiciste el Push y los archivos aparecen en GitHub, pero no se marca el cuadrito verde en tu perfil, es porque el correo configurado en tu PC no coincide con el de tu cuenta de GitHub.

Cómo arreglarlo en la terminal de VS:
Abre la terminal (Ctrl + ñ) y escribe estos comandos:

git config --global user.email "tu-correo@ejemplo.com" (Usa el correo que tienes en GitHub).

git config --global user.name "Tu Nombre de Usuario".

3. ¿Estás en la rama correcta?
A veces subes los cambios a una rama secundaria (como test o desarrollo) y en GitHub solo estás viendo la rama main (principal).

Revisa esto: En la parte superior de la página de tu repositorio en GitHub, busca un botón que dice "Branch: main". Haz clic y mira si hay otras ramas donde estén tus commits.

4. Guía Visual del Flujo de Git
Para que no se te pase ningún paso, este es el orden que siempre debes seguir en Visual Studio:

Stage (Preparar): Guardas los archivos que vas a subir (el icono de +).

Commit (Confirmar): Escribes el mensaje de qué hiciste y guardas localmente.

Push (Insertar): Envías todo a la nube (GitHub).

Tip rápido: Si ves un número con una flecha hacia arriba en la esquina inferior de Visual Studio, significa que tienes commits pendientes de enviar. ¡Haz clic ahí y listo!

¿Te aparece algún mensaje de error cuando intentas darle al botón de la flecha hacia arriba?
declaracion de ia 

