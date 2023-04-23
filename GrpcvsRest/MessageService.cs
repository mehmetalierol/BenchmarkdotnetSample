using Grpc.Core;

namespace GrpcvsRest
{
    public class MessageService : Message.MessageBase
    {
        public override Task<MessageResponse> SendMessage(MessageContent request, ServerCallContext context)
        {
            return Task.FromResult(new MessageResponse
            {
                Response = request.Body
            });
        }

        public override Task<MessageBigResponse> SendBigMessage(MessageBigContent request, ServerCallContext context)
        {
            return Task.FromResult(new MessageBigResponse
            {
                Response1 = request.Prop1,
                Response2 = request.Prop2,
                Response3 = request.Prop3,
                Response4 = request.Prop4,
                Response5 = request.Prop5,
                Response6 = request.Prop6,
                Response7 = request.Prop7,
                Response8 = request.Prop8,
                Response9 = request.Prop9,
                Response10 = request.Prop10,
                Response11 = request.Prop11,
                Response12 = request.Prop12,
                Response13 = request.Prop13,
                Response14 = request.Prop14,
                Response15 = request.Prop15,
                Response16 = request.Prop16,
                Response17 = request.Prop17,
                Response18 = request.Prop18,
                Response19 = request.Prop19,
                Response20 = request.Prop20,
            });
        }
    }
}
