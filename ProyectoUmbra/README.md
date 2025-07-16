# ProyectoUmbra

## Descripción

ProyectoUmbra es una aplicación de escritorio desarrollada en WPF (.NET 8, C# 12) que permite evaluar prompts para la generación de imágenes en Sora utilizando la API de moderación de OpenAI. El objetivo principal es analizar los prompts antes de enviarlos a Sora, ajustándolos según los resultados de la moderación para garantizar el cumplimiento de las políticas de uso.

## Características

- **Pantalla principal:** 
  - Título: "Proyecto Umbra"
  - Subtítulo: "Sistema de Moderación de contenidos"
  - Botón "Iniciar evaluación"
  - Botón pequeño con icono de hoja/pergamino y tooltip "Historial"
  - Etiqueta "Powered by OpenIA"
- **Pantalla de evaluación:** 
  - Título: "Proyecto Umbra"
  - Subtítulo: "Evaluación de Prompts"
  - Área de texto para el prompt
  - Área para visualizar la respuesta de la evaluación
  - Botón "Evaluar"
  - Barra de progreso y status de la solicitud
- **Historial de prompts:** Cada prompt evaluado se guarda en un historial accesible desde una pantalla dedicada.
- **Integración con OpenAI Moderation API:** Realiza llamadas a la API para obtener resultados de moderación en tiempo real.
- **Localización:** Todos los textos de la interfaz se gestionan mediante archivos de recursos, permitiendo versiones para desarrollo local y producción.
- **Gestión segura de la API Key:** El archivo de clave local no se sube al repositorio, mientras que un dummy sí.

## Uso

1. Ingresa un prompt en la pantalla de evaluación.
2. Visualiza el resultado de la moderación.
3. Accede al historial para consultar evaluaciones previas.

## Documentación de referencia

- [OpenAI Moderation API](https://platform.openai.com/docs/guides/moderation)

## Requisitos

- .NET 8 SDK
- Clave de API de OpenAI

## Instalación

1. Clona el repositorio.
2. Abre el proyecto en Visual Studio 2022.
3. Configura tu clave de API de OpenAI en el archivo `openai.key.local` (no se sube a GitHub).
4. Compila y ejecuta la aplicación.

## Configuración de archivos de recursos y entorno local

- Para trabajar en modo desarrollo (Debug), crea el archivo `Strings.Local.resx` en la carpeta `Resources` copiando y reemplazando el contenido del archivo `Strings.Public.resx`.
- El archivo `Strings.Local.resx` está excluido del repositorio por motivos de privacidad y personalización local.
- Si trabajas en modo producción (Release), se utilizará automáticamente el archivo `Strings.Public.resx`.

---

Este proyecto facilita la moderación de prompts para generación de imágenes, ayudando a cumplir con las políticas de OpenAI y Sora.