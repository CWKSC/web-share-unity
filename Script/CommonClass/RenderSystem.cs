using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenderSystem : MonoBehaviour
{

    public static IEnumerator SmoothFadeIn(Renderer renderer, float time = 1.0f, float maxAlpha = 1.0f, float minAlpha = 0.0f)
    {
        #region For Human to understand
        /*
        Material material = renderer.material;
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            float timeRatio = timeCount / time;
            float diffRange = maxAlpha - minAlpha;
            float alpha = minAlpha + timeRatio * diffRange;
            material.color = new Color(material.color.r,
                                       material.color.g,
                                       material.color.b,
                                       alpha);
            yield return null;
        }
        material.color = new Color(material.color.r,
                                   material.color.g,
                                   material.color.b,
                                   maxAlpha);
        //*/
        #endregion

        #region For Human to understand 2
        /*
        float diffRange = maxAlpha - minAlpha;
        yield return IEnumeratorSystem.SmoothAction(
            (timeRatio) => renderer.material.color = new Color(renderer.material.color.r,
                                                               renderer.material.color.g,
                                                               renderer.material.color.b,
                                                               minAlpha + timeRatio * diffRange),
            () => renderer.material.color = new Color(renderer.material.color.r,
                                                      renderer.material.color.g,
                                                      renderer.material.color.b,
                                                      maxAlpha),
            time);
        //*/
        #endregion

        // For machine //
        //*
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            renderer.material.color = new Color(renderer.material.color.r,
                                                renderer.material.color.g,
                                                renderer.material.color.b,
                                                minAlpha + timeCount / time * (maxAlpha - minAlpha));
            yield return null;
        }
        renderer.material.color = new Color(renderer.material.color.r,
                                            renderer.material.color.g,
                                            renderer.material.color.b,
                                            maxAlpha);
        //*/
    }

    public static IEnumerator SmoothFadeOut(Renderer renderer, float time = 1.0f, float maxAlpha = 1.0f, float minAlpha = 0.0f)
    {
        #region For Human to understand
        /*
        Material material = renderer.material;
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            float timeRatio = timeCount / time;
            float diffRange = maxAlpha - minAlpha;
            float alpha = maxAlpha - timeRatio * diffRange;
            material.color = new Color(material.color.r,
                                       material.color.g,
                                       material.color.b,
                                       alpha);
            yield return null;
        }
        material.color = new Color(material.color.r,
                                   material.color.g,
                                   material.color.b,
                                   minAlpha);
        //*/
        #endregion

        #region For Human to understand 2
        /*
        float diffRange = maxAlpha - minAlpha;
        yield return IEnumeratorSystem.SmoothAction(
            (timeRatio) => renderer.material.color = new Color(renderer.material.color.r,
                                                               renderer.material.color.g,
                                                               renderer.material.color.b,
                                                               maxAlpha - timeRatio * diffRange),
            () => renderer.material.color = new Color(renderer.material.color.r,
                                                      renderer.material.color.g,
                                                      renderer.material.color.b,
                                                      minAlpha),
            time);
        //*/
        #endregion

        // For machine //
        //*
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            renderer.material.color = new Color(renderer.material.color.r,
                                                renderer.material.color.g,
                                                renderer.material.color.b,
                                                maxAlpha - timeCount / time * (maxAlpha - minAlpha));
            yield return null;
        }
        renderer.material.color = new Color(renderer.material.color.r,
                                            renderer.material.color.g,
                                            renderer.material.color.b,
                                            minAlpha);
        //*/
    }

}
