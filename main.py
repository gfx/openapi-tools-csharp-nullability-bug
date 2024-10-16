from fastapi import FastAPI
from pydantic import BaseModel

app = FastAPI()

class HelloWorldResponse(BaseModel):
    message: str | None

@app.get("/")
def get_root() -> HelloWorldResponse:
    return HelloWorldResponse(message="Hello, World!")


if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="127.0.0.1", port=8001)
