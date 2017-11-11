I try to filter chroma key using shader.
The filtered green pixel replaced with the pixel of a render texture from another camera.

I'm using solution to filter chroma key with this technique:
https://stackoverflow.com/questions/16909816/can-someone-please-explain-this-fragment-shader-it-is-a-chroma-key-filter-gree

See demo scene how to use it.

Preview:
https://youtu.be/FE-bWpjSY5I

How to use:
1. Have 2 cameras in your scene. Obe for the green screen video and another one for background screen(Or maybe only blank screen)
2. Create material using shader/GreenScreenReplacer
3. Get sample of your green screen color in your video into Green Screen variable in the material.
4. Attach 'Camera Effect' script on green screen camera and 'Camera Replacer' script on background camera. Put material that you've made in phase 2 into both script.
5. Play your scene and your video should be playing. Adjust threshold sensitivity to set the green filter.