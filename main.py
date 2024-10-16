from fastapi import FastAPI
from pydantic import BaseModel
from typing import Optional
from datetime import datetime, timezone

app = FastAPI()


class HelloWorldResponse(BaseModel):
    message1: datetime | None
    message2: datetime | None = None
    message3: Optional[datetime]
    message4: Optional[datetime] = None


@app.get("/")
def get_root() -> HelloWorldResponse:
    return HelloWorldResponse(
        message1=datetime.now(timezone.utc),
        message3=datetime.now(timezone.utc),
    )


if __name__ == "__main__":
    import uvicorn

    uvicorn.run(app, host="127.0.0.1", port=8001)
