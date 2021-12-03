using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class GlassRenderPipeline : RenderPipeline
{
    public GlassRenderPipeline()
    {
        
    }

    protected override void Render(ScriptableRenderContext context, Camera[] cameras)
    {
        var cmd = new CommandBuffer();
        cmd.ClearRenderTarget(true, true, Color.yellow);
        context.ExecuteCommandBuffer(cmd);
        cmd.Release();

        context.Submit();
    }
}
