from fastapi import FastAPI
from pydantic import BaseModel
from typing import Optional

app = FastAPI()

class HelloWorldResponse(BaseModel):
    message1: str | None
    message2: str | None = None
    message3: Optional[str]
    message4: Optional[str] = None

@app.get("/")
def get_root() -> HelloWorldResponse:
    return HelloWorldResponse(message1="Hello, World!", message3="Hello, World!")


if __name__ == "__main__":
    import uvicorn
    uvicorn.run(app, host="127.0.0.1", port=8001)
