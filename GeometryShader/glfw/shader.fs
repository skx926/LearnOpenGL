#version 330 core
out vec4 FragColor;

//in vec3 fColor;

in vec2 TexCoords;

uniform sampler2D texture_diffuse1;

void main()
{
//    FragColor = vec4(fColor, 1.0);
    FragColor = texture(texture_diffuse1, TexCoords);
}
