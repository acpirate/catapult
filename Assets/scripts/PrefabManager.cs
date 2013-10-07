using UnityEngine;
using System.Collections;

public class PrefabManager : MonoBehaviour {
	
	public GameObject puckDustPrefabLoader;
	public Texture brickCrackedLoader;
	public Texture brickCrackedNormalLoader;
	public GameObject puckPrefabLoader;
	public GameObject startZoneLoader;
	public GameObject midZoneLoader;
	public Texture warriorTextureLoader;
	public Texture priestTextureLoader;
	public Texture wizardTextureLoader;
	public Texture rogueTextureLoader;
	public GameObject splashPrefabLoader;
	public GameObject shockFlashPrefabLoader;
	public GameObject holyExplosionPrefabLoader;
	public Shader transparentVectorShaderLoader;
	public Material brickMaterialLoader;
	public GameObject halfBrickPrefabLoader;
	public GameObject brickPrefabLoader;
	public GameObject soundControllerLoader;
	public AudioClip gameStartSoundLoader;
	public AudioClip puckFireSoundLoader;
	public AudioClip puckHitGroundSoundLoader;
	public AudioClip kingHitSoundLoader;
	public AudioClip brickBreakSoundLoader;
	public AudioClip splashSoundLoader;
	public AudioClip wizardExplosionSoundLoader;
	public AudioClip priestExplosionSoundLoader;
	public AudioClip puckHitBrickSoundLoader;

	
	public static GameObject puckDustPrefab=null;
	public static Texture brickCracked=null;
	public static Texture brickCrackedNormal=null;
	public static GameObject puckPrefab;
	public static GameObject startZone;
	public static GameObject midZone;	
	public static Texture warriorTexture;
	public static Texture priestTexture;
	public static Texture wizardTexture;
	public static Texture rogueTexture;
	public static GameObject splashPrefab=null;
	public static GameObject shockFlashPrefab=null;
	public static GameObject holyExplosionPrefab=null;
	public static Shader transparentVectorShader=null;
	public static Material brickMaterial;
	public static GameObject halfBrickPrefab=null;
	public static GameObject brickPrefab=null;
	public static GameObject soundController=null;
	public static AudioClip gameStartSound;
	public static AudioClip puckFireSound;
	public static AudioClip puckHitGroundSound;
	public static AudioClip kingHitSound;
	public static AudioClip brickBreakSound;
	public static AudioClip splashSound;
	public static AudioClip wizardExplosionSound;
	public static AudioClip priestExplosionSound;
	public static AudioClip puckHitBrickSound;
	
	
	
	// Use this for initialization
	void Awake () {
		puckDustPrefab=puckDustPrefabLoader;
		brickCracked=brickCrackedLoader;
		brickCrackedNormal=brickCrackedNormalLoader;
		puckPrefab=puckPrefabLoader;
		startZone=startZoneLoader;
		midZone=midZoneLoader;
		warriorTexture=warriorTextureLoader;
		priestTexture=priestTextureLoader;
		wizardTexture=wizardTextureLoader;
		rogueTexture=rogueTextureLoader;
		splashPrefab=splashPrefabLoader;
		shockFlashPrefab=shockFlashPrefabLoader;
		holyExplosionPrefab=holyExplosionPrefabLoader;
		transparentVectorShader=transparentVectorShaderLoader;
		brickMaterial=brickMaterialLoader;
		halfBrickPrefab=halfBrickPrefabLoader;
		brickPrefab=brickPrefabLoader;
		soundController=soundControllerLoader;
		gameStartSound=gameStartSoundLoader;
		puckFireSound=puckFireSoundLoader;
		puckHitGroundSound=puckHitGroundSoundLoader;
		kingHitSound=kingHitSoundLoader;
		brickBreakSound=brickBreakSoundLoader;
		splashSound=splashSoundLoader;
		wizardExplosionSound=wizardExplosionSoundLoader;
		priestExplosionSound=priestExplosionSoundLoader;
		puckHitBrickSound=puckHitBrickSoundLoader;
	}		
	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
