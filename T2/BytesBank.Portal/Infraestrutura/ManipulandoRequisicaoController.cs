﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BytesBank.Portal.Infraestrutura
{
    public class ManipulandoRequisicaoController
    {
        public void Manipular(HttpListenerResponse resposta, string path)
        {
            var partes = path.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var controllerNome = partes[0];
            var actionNome = partes[1];

            var ControllerNomeCompleto = $"ByteBank.Portal.Controller.{controllerNome}Controller";

            var controllerWrapper = Activator.CreateInstance("ByteBank.Portal", ControllerNomeCompleto, new object[0]);
            var controller = controllerWrapper.Unwrap();

            var methodInfo = controller.GetType().GetMethod(actionNome);

            var resultadoAction = (string)methodInfo.Invoke(controller, new object[0]);

            var buffer = Encoding.UTF8.GetBytes(resultadoAction);

            resposta.StatusCode = 200;
            resposta.ContentType = "text/html; charset=utf-8";
            resposta.ContentLength64 = buffer.Length;

            resposta.OutputStream.Write(buffer, 0, buffer.Length);
            resposta.OutputStream.Close();
        }
    }
}
