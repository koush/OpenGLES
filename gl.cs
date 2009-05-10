using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Text;

namespace OpenGLES
{
    public static class gl
    {
        public const int GL_VERSION_ES_CM_1_0 = 1;
        public const int GL_VERSION_ES_CL_1_0 = 1;
        public const int GL_VERSION_ES_CM_1_1 = 1;
        public const int GL_VERSION_ES_CL_1_1 = 1;
        public const int GL_DEPTH_BUFFER_BIT = 256;
        public const int GL_STENCIL_BUFFER_BIT = 1024;
        public const int GL_COLOR_BUFFER_BIT = 16384;
        public const int GL_FALSE = 0;
        public const int GL_TRUE = 1;
        public const int GL_POINTS = 0;
        public const int GL_LINES = 1;
        public const int GL_LINE_LOOP = 2;
        public const int GL_LINE_STRIP = 3;
        public const int GL_TRIANGLES = 4;
        public const int GL_TRIANGLE_STRIP = 5;
        public const int GL_TRIANGLE_FAN = 6;
        public const int GL_NEVER = 512;
        public const int GL_LESS = 513;
        public const int GL_EQUAL = 514;
        public const int GL_LEQUAL = 515;
        public const int GL_GREATER = 516;
        public const int GL_NOTEQUAL = 517;
        public const int GL_GEQUAL = 518;
        public const int GL_ALWAYS = 519;
        public const int GL_ZERO = 0;
        public const int GL_ONE = 1;
        public const int GL_SRC_COLOR = 768;
        public const int GL_ONE_MINUS_SRC_COLOR = 769;
        public const int GL_SRC_ALPHA = 770;
        public const int GL_ONE_MINUS_SRC_ALPHA = 771;
        public const int GL_DST_ALPHA = 772;
        public const int GL_ONE_MINUS_DST_ALPHA = 773;
        public const int GL_DST_COLOR = 774;
        public const int GL_ONE_MINUS_DST_COLOR = 775;
        public const int GL_SRC_ALPHA_SATURATE = 776;
        public const int GL_CLIP_PLANE0 = 12288;
        public const int GL_CLIP_PLANE1 = 12289;
        public const int GL_CLIP_PLANE2 = 12290;
        public const int GL_CLIP_PLANE3 = 12291;
        public const int GL_CLIP_PLANE4 = 12292;
        public const int GL_CLIP_PLANE5 = 12293;
        public const int GL_FRONT = 1028;
        public const int GL_BACK = 1029;
        public const int GL_FRONT_AND_BACK = 1032;
        public const int GL_FOG = 2912;
        public const int GL_LIGHTING = 2896;
        public const int GL_TEXTURE_2D = 3553;
        public const int GL_CULL_FACE = 2884;
        public const int GL_ALPHA_TEST = 3008;
        public const int GL_BLEND = 3042;
        public const int GL_COLOR_LOGIC_OP = 3058;
        public const int GL_DITHER = 3024;
        public const int GL_STENCIL_TEST = 2960;
        public const int GL_DEPTH_TEST = 2929;
        public const int GL_POINT_SMOOTH = 2832;
        public const int GL_LINE_SMOOTH = 2848;
        public const int GL_SCISSOR_TEST = 3089;
        public const int GL_COLOR_MATERIAL = 2903;
        public const int GL_NORMALIZE = 2977;
        public const int GL_RESCALE_NORMAL = 32826;
        public const int GL_POLYGON_OFFSET_FILL = 32823;
        public const int GL_VERTEX_ARRAY = 32884;
        public const int GL_NORMAL_ARRAY = 32885;
        public const int GL_COLOR_ARRAY = 32886;
        public const int GL_TEXTURE_COORD_ARRAY = 32888;
        public const int GL_MULTISAMPLE = 32925;
        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 32926;
        public const int GL_SAMPLE_ALPHA_TO_ONE = 32927;
        public const int GL_SAMPLE_COVERAGE = 32928;
        public const int GL_NO_ERROR = 0;
        public const int GL_INVALID_ENUM = 1280;
        public const int GL_INVALID_VALUE = 1281;
        public const int GL_INVALID_OPERATION = 1282;
        public const int GL_STACK_OVERFLOW = 1283;
        public const int GL_STACK_UNDERFLOW = 1284;
        public const int GL_OUT_OF_MEMORY = 1285;
        public const int GL_EXP = 2048;
        public const int GL_EXP2 = 2049;
        public const int GL_FOG_DENSITY = 2914;
        public const int GL_FOG_START = 2915;
        public const int GL_FOG_END = 2916;
        public const int GL_FOG_MODE = 2917;
        public const int GL_FOG_COLOR = 2918;
        public const int GL_CW = 2304;
        public const int GL_CCW = 2305;
        public const int GL_CURRENT_COLOR = 2816;
        public const int GL_CURRENT_NORMAL = 2818;
        public const int GL_CURRENT_TEXTURE_COORDS = 2819;
        public const int GL_POINT_SIZE = 2833;
        public const int GL_POINT_SIZE_MIN = 33062;
        public const int GL_POINT_SIZE_MAX = 33063;
        public const int GL_POINT_FADE_THRESHOLD_SIZE = 33064;
        public const int GL_POINT_DISTANCE_ATTENUATION = 33065;
        public const int GL_SMOOTH_POINT_SIZE_RANGE = 2834;
        public const int GL_LINE_WIDTH = 2849;
        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 2850;
        public const int GL_ALIASED_POINT_SIZE_RANGE = 33901;
        public const int GL_ALIASED_LINE_WIDTH_RANGE = 33902;
        public const int GL_CULL_FACE_MODE = 2885;
        public const int GL_FRONT_FACE = 2886;
        public const int GL_SHADE_MODEL = 2900;
        public const int GL_DEPTH_RANGE = 2928;
        public const int GL_DEPTH_WRITEMASK = 2930;
        public const int GL_DEPTH_CLEAR_VALUE = 2931;
        public const int GL_DEPTH_FUNC = 2932;
        public const int GL_STENCIL_CLEAR_VALUE = 2961;
        public const int GL_STENCIL_FUNC = 2962;
        public const int GL_STENCIL_VALUE_MASK = 2963;
        public const int GL_STENCIL_FAIL = 2964;
        public const int GL_STENCIL_PASS_DEPTH_FAIL = 2965;
        public const int GL_STENCIL_PASS_DEPTH_PASS = 2966;
        public const int GL_STENCIL_REF = 2967;
        public const int GL_STENCIL_WRITEMASK = 2968;
        public const int GL_MATRIX_MODE = 2976;
        public const int GL_VIEWPORT = 2978;
        public const int GL_MODELVIEW_STACK_DEPTH = 2979;
        public const int GL_PROJECTION_STACK_DEPTH = 2980;
        public const int GL_TEXTURE_STACK_DEPTH = 2981;
        public const int GL_MODELVIEW_MATRIX = 2982;
        public const int GL_PROJECTION_MATRIX = 2983;
        public const int GL_TEXTURE_MATRIX = 2984;
        public const int GL_ALPHA_TEST_FUNC = 3009;
        public const int GL_ALPHA_TEST_REF = 3010;
        public const int GL_BLEND_DST = 3040;
        public const int GL_BLEND_SRC = 3041;
        public const int GL_LOGIC_OP_MODE = 3056;
        public const int GL_SCISSOR_BOX = 3088;
        public const int GL_COLOR_CLEAR_VALUE = 3106;
        public const int GL_COLOR_WRITEMASK = 3107;
        public const int GL_UNPACK_ALIGNMENT = 3317;
        public const int GL_PACK_ALIGNMENT = 3333;
        public const int GL_MAX_LIGHTS = 3377;
        public const int GL_MAX_CLIP_PLANES = 3378;
        public const int GL_MAX_TEXTURE_SIZE = 3379;
        public const int GL_MAX_MODELVIEW_STACK_DEPTH = 3382;
        public const int GL_MAX_PROJECTION_STACK_DEPTH = 3384;
        public const int GL_MAX_TEXTURE_STACK_DEPTH = 3385;
        public const int GL_MAX_VIEWPORT_DIMS = 3386;
        public const int GL_MAX_TEXTURE_UNITS = 34018;
        public const int GL_SUBPIXEL_BITS = 3408;
        public const int GL_RED_BITS = 3410;
        public const int GL_GREEN_BITS = 3411;
        public const int GL_BLUE_BITS = 3412;
        public const int GL_ALPHA_BITS = 3413;
        public const int GL_DEPTH_BITS = 3414;
        public const int GL_STENCIL_BITS = 3415;
        public const int GL_POLYGON_OFFSET_UNITS = 10752;
        public const int GL_POLYGON_OFFSET_FACTOR = 32824;
        public const int GL_TEXTURE_BINDING_2D = 32873;
        public const int GL_VERTEX_ARRAY_SIZE = 32890;
        public const int GL_VERTEX_ARRAY_TYPE = 32891;
        public const int GL_VERTEX_ARRAY_STRIDE = 32892;
        public const int GL_NORMAL_ARRAY_TYPE = 32894;
        public const int GL_NORMAL_ARRAY_STRIDE = 32895;
        public const int GL_COLOR_ARRAY_SIZE = 32897;
        public const int GL_COLOR_ARRAY_TYPE = 32898;
        public const int GL_COLOR_ARRAY_STRIDE = 32899;
        public const int GL_TEXTURE_COORD_ARRAY_SIZE = 32904;
        public const int GL_TEXTURE_COORD_ARRAY_TYPE = 32905;
        public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 32906;
        public const int GL_VERTEX_ARRAY_POINTER = 32910;
        public const int GL_NORMAL_ARRAY_POINTER = 32911;
        public const int GL_COLOR_ARRAY_POINTER = 32912;
        public const int GL_TEXTURE_COORD_ARRAY_POINTER = 32914;
        public const int GL_SAMPLE_BUFFERS = 32936;
        public const int GL_SAMPLES = 32937;
        public const int GL_SAMPLE_COVERAGE_VALUE = 32938;
        public const int GL_SAMPLE_COVERAGE_INVERT = 32939;
        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 34466;
        public const int GL_COMPRESSED_TEXTURE_FORMATS = 34467;
        public const int GL_DONT_CARE = 4352;
        public const int GL_FASTEST = 4353;
        public const int GL_NICEST = 4354;
        public const int GL_PERSPECTIVE_CORRECTION_HINT = 3152;
        public const int GL_POINT_SMOOTH_HINT = 3153;
        public const int GL_LINE_SMOOTH_HINT = 3154;
        public const int GL_FOG_HINT = 3156;
        public const int GL_GENERATE_MIPMAP_HINT = 33170;
        public const int GL_LIGHT_MODEL_AMBIENT = 2899;
        public const int GL_LIGHT_MODEL_TWO_SIDE = 2898;
        public const int GL_AMBIENT = 4608;
        public const int GL_DIFFUSE = 4609;
        public const int GL_SPECULAR = 4610;
        public const int GL_POSITION = 4611;
        public const int GL_SPOT_DIRECTION = 4612;
        public const int GL_SPOT_EXPONENT = 4613;
        public const int GL_SPOT_CUTOFF = 4614;
        public const int GL_CONSTANT_ATTENUATION = 4615;
        public const int GL_LINEAR_ATTENUATION = 4616;
        public const int GL_QUADRATIC_ATTENUATION = 4617;
        public const int GL_BYTE = 5120;
        public const int GL_UNSIGNED_BYTE = 5121;
        public const int GL_SHORT = 5122;
        public const int GL_UNSIGNED_SHORT = 5123;
        public const int GL_FLOAT = 5126;
        public const int GL_FIXED = 5132;
        public const int GL_CLEAR = 5376;
        public const int GL_AND = 5377;
        public const int GL_AND_REVERSE = 5378;
        public const int GL_COPY = 5379;
        public const int GL_AND_INVERTED = 5380;
        public const int GL_NOOP = 5381;
        public const int GL_XOR = 5382;
        public const int GL_OR = 5383;
        public const int GL_NOR = 5384;
        public const int GL_EQUIV = 5385;
        public const int GL_INVERT = 5386;
        public const int GL_OR_REVERSE = 5387;
        public const int GL_COPY_INVERTED = 5388;
        public const int GL_OR_INVERTED = 5389;
        public const int GL_NAND = 5390;
        public const int GL_SET = 5391;
        public const int GL_EMISSION = 5632;
        public const int GL_SHININESS = 5633;
        public const int GL_AMBIENT_AND_DIFFUSE = 5634;
        public const int GL_MODELVIEW = 5888;
        public const int GL_PROJECTION = 5889;
        public const int GL_TEXTURE = 5890;
        public const int GL_ALPHA = 6406;
        public const int GL_RGB = 6407;
        public const int GL_RGBA = 6408;
        public const int GL_LUMINANCE = 6409;
        public const int GL_LUMINANCE_ALPHA = 6410;
        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 32819;
        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 32820;
        public const int GL_UNSIGNED_SHORT_5_6_5 = 33635;
        public const int GL_FLAT = 7424;
        public const int GL_SMOOTH = 7425;
        public const int GL_KEEP = 7680;
        public const int GL_REPLACE = 7681;
        public const int GL_INCR = 7682;
        public const int GL_DECR = 7683;
        public const int GL_VENDOR = 7936;
        public const int GL_RENDERER = 7937;
        public const int GL_VERSION = 7938;
        public const int GL_EXTENSIONS = 7939;
        public const int GL_MODULATE = 8448;
        public const int GL_DECAL = 8449;
        public const int GL_ADD = 260;
        public const int GL_TEXTURE_ENV_MODE = 8704;
        public const int GL_TEXTURE_ENV_COLOR = 8705;
        public const int GL_TEXTURE_ENV = 8960;
        public const int GL_NEAREST = 9728;
        public const int GL_LINEAR = 9729;
        public const int GL_NEAREST_MIPMAP_NEAREST = 9984;
        public const int GL_LINEAR_MIPMAP_NEAREST = 9985;
        public const int GL_NEAREST_MIPMAP_LINEAR = 9986;
        public const int GL_LINEAR_MIPMAP_LINEAR = 9987;
        public const int GL_TEXTURE_MAG_FILTER = 10240;
        public const int GL_TEXTURE_MIN_FILTER = 10241;
        public const int GL_TEXTURE_WRAP_S = 10242;
        public const int GL_TEXTURE_WRAP_T = 10243;
        public const int GL_GENERATE_MIPMAP = 33169;
        public const int GL_TEXTURE0 = 33984;
        public const int GL_TEXTURE1 = 33985;
        public const int GL_TEXTURE2 = 33986;
        public const int GL_TEXTURE3 = 33987;
        public const int GL_TEXTURE4 = 33988;
        public const int GL_TEXTURE5 = 33989;
        public const int GL_TEXTURE6 = 33990;
        public const int GL_TEXTURE7 = 33991;
        public const int GL_TEXTURE8 = 33992;
        public const int GL_TEXTURE9 = 33993;
        public const int GL_TEXTURE10 = 33994;
        public const int GL_TEXTURE11 = 33995;
        public const int GL_TEXTURE12 = 33996;
        public const int GL_TEXTURE13 = 33997;
        public const int GL_TEXTURE14 = 33998;
        public const int GL_TEXTURE15 = 33999;
        public const int GL_TEXTURE16 = 34000;
        public const int GL_TEXTURE17 = 34001;
        public const int GL_TEXTURE18 = 34002;
        public const int GL_TEXTURE19 = 34003;
        public const int GL_TEXTURE20 = 34004;
        public const int GL_TEXTURE21 = 34005;
        public const int GL_TEXTURE22 = 34006;
        public const int GL_TEXTURE23 = 34007;
        public const int GL_TEXTURE24 = 34008;
        public const int GL_TEXTURE25 = 34009;
        public const int GL_TEXTURE26 = 34010;
        public const int GL_TEXTURE27 = 34011;
        public const int GL_TEXTURE28 = 34012;
        public const int GL_TEXTURE29 = 34013;
        public const int GL_TEXTURE30 = 34014;
        public const int GL_TEXTURE31 = 34015;
        public const int GL_ACTIVE_TEXTURE = 34016;
        public const int GL_CLIENT_ACTIVE_TEXTURE = 34017;
        public const int GL_REPEAT = 10497;
        public const int GL_CLAMP_TO_EDGE = 33071;
        public const int GL_LIGHT0 = 16384;
        public const int GL_LIGHT1 = 16385;
        public const int GL_LIGHT2 = 16386;
        public const int GL_LIGHT3 = 16387;
        public const int GL_LIGHT4 = 16388;
        public const int GL_LIGHT5 = 16389;
        public const int GL_LIGHT6 = 16390;
        public const int GL_LIGHT7 = 16391;
        public const int GL_ARRAY_BUFFER = 34962;
        public const int GL_ELEMENT_ARRAY_BUFFER = 34963;
        public const int GL_ARRAY_BUFFER_BINDING = 34964;
        public const int GL_ELEMENT_ARRAY_BUFFER_BINDING = 34965;
        public const int GL_VERTEX_ARRAY_BUFFER_BINDING = 34966;
        public const int GL_NORMAL_ARRAY_BUFFER_BINDING = 34967;
        public const int GL_COLOR_ARRAY_BUFFER_BINDING = 34968;
        public const int GL_TEXTURE_COORD_ARRAY_BUFFER_BINDING = 34970;
        public const int GL_STATIC_DRAW = 35044;
        public const int GL_DYNAMIC_DRAW = 35048;
        public const int GL_BUFFER_SIZE = 34660;
        public const int GL_BUFFER_USAGE = 34661;
        public const int GL_SUBTRACT = 34023;
        public const int GL_COMBINE = 34160;
        public const int GL_COMBINE_RGB = 34161;
        public const int GL_COMBINE_ALPHA = 34162;
        public const int GL_RGB_SCALE = 34163;
        public const int GL_ADD_SIGNED = 34164;
        public const int GL_INTERPOLATE = 34165;
        public const int GL_CONSTANT = 34166;
        public const int GL_PRIMARY_COLOR = 34167;
        public const int GL_PREVIOUS = 34168;
        public const int GL_OPERAND0_RGB = 34192;
        public const int GL_OPERAND1_RGB = 34193;
        public const int GL_OPERAND2_RGB = 34194;
        public const int GL_OPERAND0_ALPHA = 34200;
        public const int GL_OPERAND1_ALPHA = 34201;
        public const int GL_OPERAND2_ALPHA = 34202;
        public const int GL_ALPHA_SCALE = 3356;
        public const int GL_SRC0_RGB = 34176;
        public const int GL_SRC1_RGB = 34177;
        public const int GL_SRC2_RGB = 34178;
        public const int GL_SRC0_ALPHA = 34184;
        public const int GL_SRC1_ALPHA = 34185;
        public const int GL_SRC2_ALPHA = 34186;
        public const int GL_DOT3_RGB = 34478;
        public const int GL_DOT3_RGBA = 34479;
        public const int GL_IMPLEMENTATION_COLOR_READ_TYPE_OES = 35738;
        public const int GL_IMPLEMENTATION_COLOR_READ_FORMAT_OES = 35739;
        public const int GL_PALETTE4_RGB8_OES = 35728;
        public const int GL_PALETTE4_RGBA8_OES = 35729;
        public const int GL_PALETTE4_R5_G6_B5_OES = 35730;
        public const int GL_PALETTE4_RGBA4_OES = 35731;
        public const int GL_PALETTE4_RGB5_A1_OES = 35732;
        public const int GL_PALETTE8_RGB8_OES = 35733;
        public const int GL_PALETTE8_RGBA8_OES = 35734;
        public const int GL_PALETTE8_R5_G6_B5_OES = 35735;
        public const int GL_PALETTE8_RGBA4_OES = 35736;
        public const int GL_PALETTE8_RGB5_A1_OES = 35737;
        public const int GL_POINT_SIZE_ARRAY_OES = 35740;
        public const int GL_POINT_SIZE_ARRAY_TYPE_OES = 35210;
        public const int GL_POINT_SIZE_ARRAY_STRIDE_OES = 35211;
        public const int GL_POINT_SIZE_ARRAY_POINTER_OES = 35212;
        public const int GL_POINT_SIZE_ARRAY_BUFFER_BINDING_OES = 35743;
        public const int GL_POINT_SPRITE_OES = 34913;
        public const int GL_COORD_REPLACE_OES = 34914;
        public const int GL_OES_read_format = 1;
        public const int GL_OES_compressed_paletted_texture = 1;
        public const int GL_OES_point_size_array = 1;
        public const int GL_OES_point_sprite = 1;

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glAlphaFunc")]
        public static extern void AlphaFunc(uint func, float @ref);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClearColor")]
        public static extern void ClearColor(float red, float green, float blue, float alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClearDepthf")]
        public static extern void ClearDepthf(float depth);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClipPlanef")]
        unsafe public static extern void ClipPlanef(uint plane, float* equation);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glColor4f")]
        public static extern void Color4f(float red, float green, float blue, float alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDepthRangef")]
        public static extern void DepthRangef(float zNear, float zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFogf")]
        public static extern void Fogf(uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFogfv")]
        unsafe public static extern void Fogfv(uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFrustumf")]
        public static extern void Frustumf(float left, float right, float bottom, float top, float zNear, float zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetFloatv")]
        unsafe public static extern void GetFloatv(uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetLightfv")]
        unsafe public static extern void GetLightfv(uint light, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetMaterialfv")]
        unsafe public static extern void GetMaterialfv(uint face, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexEnvfv")]
        unsafe public static extern void GetTexEnvfv(uint env, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexParameterfv")]
        unsafe public static extern void GetTexParameterfv(uint target, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightModelf")]
        public static extern void LightModelf(uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightModelfv")]
        unsafe public static extern void LightModelfv(uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightf")]
        public static extern void Lightf(uint light, uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightfv")]
        unsafe public static extern void Lightfv(uint light, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLineWidth")]
        public static extern void LineWidth(float width);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLoadMatrixf")]
        unsafe public static extern void LoadMatrixf(float* m);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMaterialf")]
        public static extern void Materialf(uint face, uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMaterialfv")]
        unsafe public static extern void Materialfv(uint face, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMultMatrixf")]
        unsafe public static extern void MultMatrixf(float* m);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMultiTexCoord4f")]
        public static extern void MultiTexCoord4f(uint target, float s, float t, float r, float q);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glNormal3f")]
        public static extern void Normal3f(float nx, float ny, float nz);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glOrthof")]
        public static extern void Orthof(float left, float right, float bottom, float top, float zNear, float zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointParameterf")]
        public static extern void PointParameterf(uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointParameterfv")]
        unsafe public static extern void PointParameterfv(uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointSize")]
        public static extern void PointSize(float size);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPolygonOffset")]
        public static extern void PolygonOffset(float factor, float units);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glRotatef")]
        public static extern void Rotatef(float angle, float x, float y, float z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glScalef")]
        public static extern void Scalef(float x, float y, float z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnvf")]
        public static extern void TexEnvf(uint target, uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnvfv")]
        unsafe public static extern void TexEnvfv(uint target, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameterf")]
        public static extern void TexParameterf(uint target, uint pname, float param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameterfv")]
        unsafe public static extern void TexParameterfv(uint target, uint pname, float* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTranslatef")]
        public static extern void Translatef(float x, float y, float z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glActiveTexture")]
        public static extern void ActiveTexture(uint texture);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glAlphaFuncx")]
        public static extern void AlphaFuncx(uint func, int @ref);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glBindBuffer")]
        public static extern void BindBuffer(uint target, uint buffer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glBindTexture")]
        public static extern void BindTexture(uint target, uint texture);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glBlendFunc")]
        public static extern void BlendFunc(uint sfactor, uint dfactor);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glBufferData")]
        public static extern void BufferData(uint target, int size, System.IntPtr data, uint usage);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glBufferSubData")]
        public static extern void BufferSubData(uint target, int offset, int size, System.IntPtr data);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClear")]
        public static extern void Clear(uint mask);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClearColorx")]
        public static extern void ClearColorx(int red, int green, int blue, int alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClearDepthx")]
        public static extern void ClearDepthx(int depth);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClearStencil")]
        public static extern void ClearStencil(int s);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClientActiveTexture")]
        public static extern void ClientActiveTexture(uint texture);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glClipPlanex")]
        unsafe public static extern void ClipPlanex(uint plane, int* equation);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glColor4ub")]
        public static extern void Color4ub(byte red, byte green, byte blue, byte alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glColor4x")]
        public static extern void Color4x(int red, int green, int blue, int alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glColorMask")]
        public static extern void ColorMask(byte red, byte green, byte blue, byte alpha);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glColorPointer")]
        public static extern void ColorPointer(int size, uint type, int stride, System.IntPtr pointer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glCompressedTexImage2D")]
        public static extern void CompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, System.IntPtr data);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glCompressedTexSubImage2D")]
        public static extern void CompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, System.IntPtr data);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glCopyTexImage2D")]
        public static extern void CopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glCopyTexSubImage2D")]
        public static extern void CopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glCullFace")]
        public static extern void CullFace(uint mode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDeleteBuffers")]
        unsafe public static extern void DeleteBuffers(int n, uint* buffers);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDeleteTextures")]
        unsafe public static extern void DeleteTextures(int n, uint* textures);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDepthFunc")]
        public static extern void DepthFunc(uint func);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDepthMask")]
        public static extern void DepthMask(byte flag);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDepthRangex")]
        public static extern void DepthRangex(int zNear, int zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDisable")]
        public static extern void Disable(uint cap);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDisableClientState")]
        public static extern void DisableClientState(uint array);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDrawArrays")]
        public static extern void DrawArrays(uint mode, int first, int count);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glDrawElements")]
        public static extern void DrawElements(uint mode, int count, uint type, System.IntPtr indices);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glEnable")]
        public static extern void Enable(uint cap);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glEnableClientState")]
        public static extern void EnableClientState(uint array);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFinish")]
        public static extern void Finish();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFlush")]
        public static extern void Flush();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFogx")]
        public static extern void Fogx(uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFogxv")]
        unsafe public static extern void Fogxv(uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFrontFace")]
        public static extern void FrontFace(uint mode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glFrustumx")]
        public static extern void Frustumx(int left, int right, int bottom, int top, int zNear, int zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetBooleanv")]
        public static extern void GetBooleanv(uint pname, System.IntPtr @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetBufferParameteriv")]
        unsafe public static extern void GetBufferParameteriv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGenBuffers")]
        unsafe public static extern void GenBuffers(int n, uint* buffers);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGenTextures")]
        unsafe public static extern void GenTextures(int n, uint* textures);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetError")]
        public static extern uint GetError();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetFixedv")]
        unsafe public static extern void GetFixedv(uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetIntegerv")]
        unsafe public static extern void GetIntegerv(uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetLightxv")]
        unsafe public static extern void GetLightxv(uint light, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetMaterialxv")]
        unsafe public static extern void GetMaterialxv(uint face, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetPointerv")]
        unsafe public static extern void GetPointerv(uint pname, IntPtr* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetString")]
        public static extern System.IntPtr GetString(uint name);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexEnviv")]
        unsafe public static extern void GetTexEnviv(uint env, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexEnvxv")]
        unsafe public static extern void GetTexEnvxv(uint env, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexParameteriv")]
        unsafe public static extern void GetTexParameteriv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetTexParameterxv")]
        unsafe public static extern void GetTexParameterxv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glHint")]
        public static extern void Hint(uint target, uint mode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glIsBuffer")]
        public static extern byte IsBuffer(uint buffer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glIsEnabled")]
        public static extern byte IsEnabled(uint cap);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glIsTexture")]
        public static extern byte IsTexture(uint texture);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightModelx")]
        public static extern void LightModelx(uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightModelxv")]
        unsafe public static extern void LightModelxv(uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightx")]
        public static extern void Lightx(uint light, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLightxv")]
        unsafe public static extern void Lightxv(uint light, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLineWidthx")]
        public static extern void LineWidthx(int width);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLoadIdentity")]
        public static extern void LoadIdentity();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLoadMatrixx")]
        public static extern void LoadMatrixx(ref int m);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glLogicOp")]
        public static extern void LogicOp(uint opcode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMaterialx")]
        public static extern void Materialx(uint face, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMaterialxv")]
        unsafe public static extern void Materialxv(uint face, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMatrixMode")]
        public static extern void MatrixMode(uint mode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMultMatrixx")]
        unsafe public static extern void MultMatrixx(int* m);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glMultiTexCoord4x")]
        public static extern void MultiTexCoord4x(uint target, int s, int t, int r, int q);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glNormal3x")]
        public static extern void Normal3x(int nx, int ny, int nz);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glNormalPointer")]
        public static extern void NormalPointer(uint type, int stride, System.IntPtr pointer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glOrthox")]
        public static extern void Orthox(int left, int right, int bottom, int top, int zNear, int zFar);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPixelStorei")]
        public static extern void PixelStorei(uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointParameterx")]
        public static extern void PointParameterx(uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointParameterxv")]
        unsafe public static extern void PointParameterxv(uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointSizex")]
        public static extern void PointSizex(int size);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPolygonOffsetx")]
        public static extern void PolygonOffsetx(int factor, int units);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPopMatrix")]
        public static extern void PopMatrix();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPushMatrix")]
        public static extern void PushMatrix();

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glReadPixels")]
        public static extern void ReadPixels(int x, int y, int width, int height, uint format, uint type, System.IntPtr pixels);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glRotatex")]
        public static extern void Rotatex(int angle, int x, int y, int z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glSampleCoverage")]
        public static extern void SampleCoverage(float value, byte invert);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glSampleCoveragex")]
        public static extern void SampleCoveragex(int value, byte invert);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glScalex")]
        public static extern void Scalex(int x, int y, int z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glScissor")]
        public static extern void Scissor(int x, int y, int width, int height);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glShadeModel")]
        public static extern void ShadeModel(uint mode);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glStencilFunc")]
        public static extern void StencilFunc(uint func, int @ref, uint mask);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glStencilMask")]
        public static extern void StencilMask(uint mask);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glStencilOp")]
        public static extern void StencilOp(uint fail, uint zfail, uint zpass);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexCoordPointer")]
        public static extern void TexCoordPointer(int size, uint type, int stride, System.IntPtr pointer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnvi")]
        public static extern void TexEnvi(uint target, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnvx")]
        public static extern void TexEnvx(uint target, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnviv")]
        unsafe public static extern void TexEnviv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexEnvxv")]
        unsafe public static extern void TexEnvxv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexImage2D")]
        public static extern void TexImage2D(uint target, int level, uint internalformat, int width, int height, int border, uint format, uint type, System.IntPtr pixels);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameteri")]
        public static extern void TexParameteri(uint target, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameterx")]
        public static extern void TexParameterx(uint target, uint pname, int param);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameteriv")]
        unsafe public static extern void TexParameteriv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexParameterxv")]
        unsafe public static extern void TexParameterxv(uint target, uint pname, int* @params);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTexSubImage2D")]
        public static extern void TexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, System.IntPtr pixels);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glTranslatex")]
        public static extern void Translatex(int x, int y, int z);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glVertexPointer")]
        public static extern void VertexPointer(int size, uint type, int stride, System.IntPtr pointer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glViewport")]
        public static extern void Viewport(int x, int y, int width, int height);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glPointSizePointerOES")]
        public static extern void PointSizePointerOES(uint type, int stride, System.IntPtr pointer);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetClipPlanef")]
        unsafe public static extern void GetClipPlanef(uint pname, float* eqn);

        [DllImportAttribute("libgles_cm.dll", EntryPoint = "glGetClipPlanex")]
        unsafe public static extern void GetClipPlanex(uint pname, int* eqn);
    }
}