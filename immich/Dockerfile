FROM python:3.12-slim

WORKDIR /app

COPY requirements.txt .
RUN pip install --no-cache-dir -r requirements.txt

COPY authentik/ authentik/
COPY immich/ immich/

CMD ["python", "-m", "immich.main"]
